using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromSayıveMetin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome Checker");

            Console.WriteLine("Choose an option");
            Console.WriteLine("1. Check Palindrome String");
            Console.WriteLine("2. Check Palindrome Number");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
            {
                Console.WriteLine("Invalid Choice. Please Enter 1 or 2.");
            }
            switch (choice)
            {
                case 1:
                    CheckPalindromeString();
                    break;

                case 2:
                    CheckPalindromeNumber();
                    break;
               
            }
        }
        static void CheckPalindromeString()
        {
            Console.WriteLine("Enter a string: ");
            string inputString = Console.ReadLine();
            bool isStringPalindrome = IsPalindrome(inputString);

            if (isStringPalindrome)
            {
                Console.WriteLine($"{inputString} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{inputString} is not a palindrome");
            }
        }

        static void CheckPalindromeNumber()
        {
            Console.Write("Enter a integer: ");
            string inputInteger = Console.ReadLine();
            bool isIntegerPalindrome = IsPalindrome(inputInteger);
            if (isIntegerPalindrome)
                Console.WriteLine($"{inputInteger} is a palindrome");
            else
                Console.WriteLine($"{inputInteger} is not a palindrome");
        }
        static bool IsPalindrome(string input)
        {
            input = input.Replace(" ", "").ToLower();
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                    return false;
            }
            return true;
        }
        static bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;
            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number = number / 10;
            }
            return originalNumber == number;
        }
    }
}
