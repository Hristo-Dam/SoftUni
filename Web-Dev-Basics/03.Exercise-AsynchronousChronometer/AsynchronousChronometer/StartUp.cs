using System.Xml.Serialization;

namespace AsynchronousChronometer
{
    public class StartUp
    {
        public static void Main()
        {
            Chronometer chronometer = new Chronometer();

            // TODO: Write the console manipulation logic here...
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "exit")
                {
                    break;
                }
                switch (command)
                {
                    case "start":
                        chronometer.Start();
                        break;
                    case "stop":
                        chronometer.Stop();
                        break;
                    case "lap":
                        Console.WriteLine(chronometer.Lap());
                        break;
                    case "laps":
                        if (chronometer.Laps.Count == 0)
                        {
                            Console.WriteLine("No laps");
                        }
                        else
                        {
                            Console.WriteLine("Laps:");
                            int count = 0;
                            foreach (var lap in chronometer.Laps)
                            {
                                Console.WriteLine($"{count}. {lap}");
                                count++;
                            }
                        }
                        break;
                    case "time":
                        Console.WriteLine(chronometer.GetTime);
                        break;
                    case "reset":
                        chronometer.Reset();
                        chronometer.Laps.Clear();
                        break;
                }
            }
        }
    }
}
