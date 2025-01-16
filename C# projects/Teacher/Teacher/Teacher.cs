using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher
{
    internal class Teacher
    {
        private string name;
        private string gender;
        private string subject;
        private int level;
        private int angerScore;
        private int happinesScore;

        public Teacher(string name, string subject, string gender)
        {
            this.Name = name;
            this.Subject = subject;
            this.Gender = gender;
        }

        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public int AngerScore
        {
            get { return angerScore; }
            set { angerScore = value; }
        }

        public int HappinesScore
        {
            get { return happinesScore; }
            set { happinesScore = value; }
        }

        public void Teach()
        {
            Level++;
            Console.WriteLine($"You have leveled up! You are now level {this.Level} teacher!");
        }

        public void WhoAmI()
        {
            Console.WriteLine($"Name: {this.Name}\nGender: {this.Gender}\nSubject: {this.Subject}\nLevel: {this.Level}");
        }
    }
}
