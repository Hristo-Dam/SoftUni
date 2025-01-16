using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public class DateModifier
    {
        public void CalculateDif(string firstInput, string secondInput)
        {
            int[] dateOne = firstInput
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] dateTwo = secondInput
                .Split()
                .Select(int.Parse)
                .ToArray();

            DateTime firstDate = new DateTime(dateOne[0], dateOne[1], dateOne[2]);
            DateTime secondDate = new DateTime(dateTwo[0], dateTwo[1], dateTwo[2]);

            TimeSpan dateDif;

            if (firstDate > secondDate)
            {
                dateDif = firstDate.Subtract(secondDate);
            }
            else
            {
                dateDif = secondDate.Subtract(firstDate);
            }

            string[] result = dateDif
                .ToString()
                .Split('.')
                .ToArray();

            Console.WriteLine(result[0]);
        }
    }
}
