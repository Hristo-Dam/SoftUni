string message = "";

string stringInput = Console.ReadLine();
var resultstring = new string(stringInput.ToCharArray().Reverse().ToArray());
message = (resultstring);

string codedLetter = "";
string displayLet = "";
int letNum = message.Count();
int n = letNum;

Console.WriteLine();
for (int i = 0; i < n; i++)
{
    codedLetter = message.Substring(i, 1);
    switch (codedLetter)
    {
        case "a":
            displayLet = "+";
            break;
        case "e":
            displayLet = "++";
            break;
        case "i":
            displayLet = "+++";
            break;
        case "o":
            displayLet = "++++";
            break;
        case "u":
            displayLet = "+++++";
            break;
        case "y":
            displayLet = "++++++";
            break;
        case " ":
            displayLet = "|";
            break;
        case "1":
            displayLet = "!";
            break;
        case "2":
            displayLet = "@";
            break;
        case "3":
            displayLet = "#";
            break;
        case "4":
            displayLet = "$";
            break;
        case "5":
            displayLet = "%";
            break;
        case "6":
            displayLet = "^";
            break;
        case "7":
            displayLet = "&";
            break;
        case "8":
            displayLet = "*";
            break;
        case "9":
            displayLet= "(";
            break;
        case "0":
            displayLet= ")";
            break;
            default:
            displayLet = codedLetter;
            break;
    }
    Console.WriteLine(displayLet);
}