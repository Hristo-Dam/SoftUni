using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    internal class DateCounter
    {
        public void Calculate(string firstInput, string secondInput)
        {
            int[] splitFirstInput = firstInput
                .Split('/')
                .Select(int.Parse)
                .ToArray();

            int[] splitSecondInput = secondInput
                .Split('/')
                .Select(int.Parse)
                .ToArray();

            DateTime firstDate = new DateTime(splitFirstInput[0], splitFirstInput[1], splitFirstInput[2]);
            DateTime secondDate = new DateTime(splitSecondInput[0], splitSecondInput[1], splitSecondInput[2]);

            TimeSpan difference;

            if (firstDate > secondDate)
            {
                difference = firstDate - secondDate;
            }
            else
            {
                difference = secondDate - firstDate;
            }

            Console.WriteLine(difference.Days);
        }
    }
}
