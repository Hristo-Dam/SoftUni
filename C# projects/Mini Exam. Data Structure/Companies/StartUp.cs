using System.Text;

namespace Companies
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> companies = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" | ");
                string companyName = input[0];
                string ownerName = input[1];

                companies.Add(companyName, ownerName);
            }

            companies = companies.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            string[] letterRange = Console.ReadLine()
                .Split(" - ");

            char startLetter = char.Parse(letterRange[0].ToUpper());
            char endLetter = char.Parse(letterRange[1].ToUpper());

            foreach (KeyValuePair<string, string> kvp in companies)
            {
                char ownerFirstLetter = kvp.Value[0];

                if (ownerFirstLetter >= startLetter && ownerFirstLetter < endLetter)
                {
                    Console.WriteLine($"{kvp.Value} - {kvp.Key}");
                }
            }
        }
    }
}
