using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
        int minLength = 8;
        string uppercase;
        string lowercase;
        string digits;
        string specialChars;
        int score = 0;


        Console.WriteLine("input your password");
        string password = Console.ReadLine();

        Console.WriteLine("your password is: " + password);

        int len = password.Length;
        Console.WriteLine("Length of your password is: " + len);

        if (len >= minLength)
        {
          score++;
        }

        if (Tools.Contains(password, "ABCDEFGHIJKLMNOPQRSTUVWXYZ"))
        {
          score++;
        }
//check for uppercase
                if (Tools.Contains(password, "abcdefghijklmnopqrstuvwxyz"))
        {
          score++;
        }
//Check for lowercase
                if (Tools.Contains(password, "1234567890"))
        {
          score++;
        }
//Check for Numbers
                if (Tools.Contains(password, "!£$%^&*()"))
        {
          score++;
        }
        //Check for Special Characters

Console.WriteLine("Your Password Score is: " + score);

switch (score)
{
  case 5:
  case 4:
    Console.WriteLine("Extremely Strong password.");
    break;
 case 3:
    Console.WriteLine("Strong password there bucko.");
    break;
 case 2:
    Console.WriteLine("Medium password, maybe mix it up.");
    break;
 case 1:
    Console.WriteLine("Password is weak, do you even lift bro.");
    break;
 case 0:
    Console.WriteLine("Just go again, you've met none of the criteria");
    break;
default:
    Console.WriteLine("Hmm, must be an error old chap?");
    break;
}


    }
  }
}
