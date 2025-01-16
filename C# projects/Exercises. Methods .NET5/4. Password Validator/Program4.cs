using System;

namespace _4._Password_Validator
{
    internal class Program
    {
        static bool CheckNumberOfCharacters(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckForTwoDigits(string password)
        {
            int letterCount = 0;
            int numberCount = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (IsDigit(password[i]))
                {
                    letterCount++;
                }
            }
            return;
        }

        static bool ChekForOnlyLettersAndDigits(string password)
        {
            return true;
        }

        static bool IsLetter(char c)
        {
            return (c >= 'a' && c <= 'z') || c >= 'A' && c <= 'Z';
        }

        static bool IsDigit(char c)
        {
            return c >= '0' && c <= '9';
        }

        static void Main(string[] args)
        {
            bool validPassword = true;
            string password = Console.ReadLine();

            if (!CheckNumberOfCharacters(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                validPassword = false;
            }

            if (!ChekForOnlyLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                validPassword = false;
            }

            if (!CheckForTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
                validPassword = false;
            }

            if (validPassword)
            {
                Console.WriteLine("Password if valid");
            }
        }
    }
}



//static bool CheckNumberOfCharacters(string password)
//{
//    if (password.Length >= 6 && password.Length <= 10)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}

//static bool CheckForTwoDigits(string password)
//{
//    int letterCount = 0;
//    int numberCount = 0;
//    for (int i = 0; i < password.Length; i++)
//    {
//        if (IsDigit(password[i]))
//        {
//            letterCount++;
//        }
//    }
//    return ;
//}

//static bool ChekForOnlyLettersAndDigits(string password)
//{
//    return true;
//}

//static bool IsLetter(char c)
//{
//    return (c >= 'a' && c <= 'z') || c >= 'A' && c <= 'Z';
//}

//static bool IsDigit(char c)
//{
//    return c >= '0' && c <= '9';
//}

//static void Main(string[] args)
//{
//    bool validPassword = true;
//    string password = Console.ReadLine();

//    if (!CheckNumberOfCharacters(password))
//    {
//        Console.WriteLine("Password must be between 6 and 10 characters");
//        validPassword = false;
//    }

//    if (!ChekForOnlyLettersAndDigits(password))
//    {
//        Console.WriteLine("Password must consist only of letters and digits");
//        validPassword = false;
//    }

//    if (!CheckForTwoDigits(password))
//    {
//        Console.WriteLine("Password must have at least 2 digits");
//        validPassword = false;
//    }

//    if (validPassword)
//    {
//        Console.WriteLine("Password if valid");
//    }
//}