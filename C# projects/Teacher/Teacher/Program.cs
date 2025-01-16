using System;
//Hristo, Raya, Koko
namespace Teacher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Martin", "Programming", "Male");
            teacher.WhoAmI();
            teacher.Teach();
                 
        }
    }
}
