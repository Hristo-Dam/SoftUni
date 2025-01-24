namespace SpecialVariations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[] allLetters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            GenerateCombinations(new char[n], 0, 0, n, allLetters);
        }
        public static void GenerateCombinations(char[] current, int index, int start, int n, char[] allLetters)
        {
            if (index == n)
            {
                Console.WriteLine(new string(current));
                return;
            }

            for (int i = start; i < n; i++)
            {
                current[index] = allLetters[i];
                GenerateCombinations(current, index + 1, i, n, allLetters);
            }
        }
    }
}
