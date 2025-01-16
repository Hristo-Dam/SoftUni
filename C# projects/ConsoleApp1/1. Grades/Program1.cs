using System;

namespace _1._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade1 = double.Parse(Console.ReadLine());

            GradeInWords(grade1);
        }

        static void GradeInWords(double grade2)
        {
            string gradeInWords = string.Empty;

            if (grade2 >= 2.00 && grade2 <= 2.99)
            {
                gradeInWords = "Fail";
            }
            else if (grade2 >= 3.00 && grade2 <= 3.49)
            {
                gradeInWords = "Poor";
            }
            else if (grade2 >= 3.50 && grade2 <= 4.49)
            {
                gradeInWords = "Good";
            }
            else if (grade2 >= 4.50 && grade2 <= 5.49)
            {
                gradeInWords = "Very good";
            }
            else if (grade2 >= 5.50 && grade2 <= 6.00)
            {
                gradeInWords = "Excellent"; 
            }

            Console.WriteLine(gradeInWords);

        }
    }
}
