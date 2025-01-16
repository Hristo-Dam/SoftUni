namespace BasicArrayList___Exam
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            // Write the solutions in ArrayList.cs

            //ArrayList shopingList = new ArrayList();
            //shopingList.Add(4);
            //shopingList.Add(2);
            //shopingList.Add(4);
            //shopingList.Add(4);
            //shopingList.Add(3);
            //shopingList.Add(8);

            //Console.WriteLine(shopingList.CountFreePositions());
            //shopingList.Cut(3);
            //Console.WriteLine(shopingList.CountFreePositions());
            //Console.WriteLine(shopingList.Change(3, 5));

            ArrayList shopingList = new ArrayList();
            shopingList.Add(1);
            shopingList.Add(2);
            shopingList.Add(3);
            shopingList.Add(4);
            shopingList.Add(5);
            shopingList.Add(6);
            shopingList.Cut(3);
            Console.WriteLine(shopingList.Count);
            Console.WriteLine(shopingList.CountFreePositions());
        }
    }
}