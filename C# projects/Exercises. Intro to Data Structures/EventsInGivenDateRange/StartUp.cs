using Wintellect.PowerCollections;
using System.Threading;
using System.Globalization;

namespace EventsInGivenDateRange
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            OrderedMultiDictionary<DateTime, string> events = new OrderedMultiDictionary<DateTime, string>(true);

            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] eventTokens = Console.ReadLine()
                    .Split(" | ");
                string eventNum = eventTokens[0];
                DateTime eventDate = DateTime.Parse(eventTokens[1]);
                events.Add(eventDate, eventNum);
            }
        }
    }
}
