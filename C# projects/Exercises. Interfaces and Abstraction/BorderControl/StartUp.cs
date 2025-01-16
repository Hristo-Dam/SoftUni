namespace BorderControl
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<string> ids = new List<string>();

            string[] command = Console.ReadLine()
                .Split(" ")
                .ToArray();

            while (command[0] != "End")
            {
                int indexToGet = command.Length - 1;
                string itemToAdd = command[indexToGet];
                ids.Add(itemToAdd);

                command = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
            }

            string fakeDigits = Console.ReadLine();

            foreach (string id in ids)
            {
                if (fakeDigits.Length >= 3)
                {
                    if (id.EndsWith(fakeDigits))
                    {
                        Console.WriteLine(id);
                    }
                }
            }
        }
    }
}
