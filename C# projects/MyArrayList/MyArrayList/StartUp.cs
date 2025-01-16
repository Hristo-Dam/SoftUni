namespace MyArrayList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            CustomArrayList<string> list = new CustomArrayList<string>();

            list.Add("1");
            list.Add("2");
            Console.WriteLine(list.Contains("2"));

        }
    }
}