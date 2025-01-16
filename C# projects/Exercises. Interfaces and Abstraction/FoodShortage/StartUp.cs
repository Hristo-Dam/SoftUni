namespace FoodShortage
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> citizenNames = new List<string>();
            List<string> rebelNames = new List<string>();

            string[] input = Console.ReadLine()
                .Split(" ")
                .ToArray();

            string itemToAdd = input[0];

            for (int i = 0; i < n; i++)
            {
                if (input.Length == 4)
                {
                    citizenNames.Add(input[0]);
                }
                else if (input.Length == 3)
                {
                    rebelNames.Add(input[0]);
                }
                input = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
            }

            int sumOfFood = 0;

            while (input[0] != "End")
            {
                if (citizenNames.Contains(input[0]))
                {
                    sumOfFood += 10;
                }
                else if (rebelNames.Contains(input[0]))
                {
                    sumOfFood += 5;
                }

                input = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
            }

            Console.WriteLine(sumOfFood);
        }
    }
}
