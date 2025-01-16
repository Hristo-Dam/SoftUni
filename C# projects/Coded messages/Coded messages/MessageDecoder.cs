bool isEnd = false;
string word = "";
string letter = "";
string addedLetters = "";
int position = 1;

while(isEnd == false)
{
    word = Console.ReadLine();
    switch (word)
    {
        case "+":
            word = "a";
            break;
        case "++":
            word = "e";
            break;
        case "+++":
            word = "i";
            break;
        case "++++":
            word = "o";
            break;
        case "+++++":
            word = "u";
            break;
        case "++++++":
            word = "y";
            break;
        case "|":
            word = " ";
            break;
        case "!":
            word = "1";
            break;
        case "@":
            word = "2";
            break;
        case "#":
            word = "3";
            break;
        case "$":
            word = "4";
            break;
        case "%":
            word = "5";
            break;
        case "^":
            word = "6";
            break;
        case "&":
            word = "7";
            break;
        case "*":
            word = "8";
            break;
        case "(":
            word = "9";
            break;
        case ")":
            word = "0";
            break;
    }
    if (word == "stopstop")
    {
        isEnd = true;
    }
    else
    {
        letter = word.Substring(0, 1);
        addedLetters = letter.Insert(position, addedLetters);
    }
}

Console.Write(addedLetters);
