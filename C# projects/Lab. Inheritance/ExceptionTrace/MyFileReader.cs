using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTrace
{
    internal class MyFileReader
    {
        private string _path;
        
        public MyFileReader(string path)
        {
            this.Path = path;
        }

        public string Path
        {
            get { return _path; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid Path or File Name.");
                }
                else
                {
                    this._path = value;
                }
            }// . . . .
        }

        public void ReadAndSum()
        {
            string[] inputFromFile = File.ReadAllLines(this.Path);
            List<int> number = new List<int>();
            int countRow = 0;

            foreach (string value in inputFromFile)
            {
                countRow++;
                try
                {
                    int currentNum = int.Parse(value);
                    number.Add(currentNum);
                }
                catch (Exception)
                {
                    throw new ArgumentException
                        ($"Error: On the line {countRow} of the file the value was not in the correct format.");
                }
                try
                {
                    MyFileReader reader1 = new MyFileReader(@"C:\temp\numbers.txt");
                    reader1.ReadAndSum();
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine("Error: " + ex.Message);
                }
                try
                {
                    MyFileReader reader2 = new MyFileReader(@"");
                    reader2.ReadAndSum();
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
