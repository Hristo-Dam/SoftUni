string message = Console.ReadLine();
string codedLetter = "";
int n = int.Parse(Console.ReadLine());
string displayLet = "";

for (int i = 0; i < n; i++)
{
    if (codedLetter == "e")
    {
        codedLetter = "**";
    }
    displayLet = codedLetter.Substring(i, 1);
    Console.WriteLine(displayLet);
}


/*string one = Console.ReadLine();
string two = "";
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    two = one.Substring(i, 1);
    Console.WriteLine(two);
}*/


