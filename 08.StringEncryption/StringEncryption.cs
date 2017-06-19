using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string encryptedString = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char inputChar = char.Parse(Console.ReadLine());
                encryptedString += EncryptChars(inputChar);
            }

            Console.WriteLine(encryptedString);
        }

        static string EncryptChars(char inputChar)
        {
            string append = string.Empty;
            int firstDigit = GetFirstDigit(inputChar);
            int lastDigit = GetLastDigit(inputChar);
            char firstEncryptedPart = (char)(inputChar + lastDigit);
            char secondEncryptedPart = (char)(inputChar - firstDigit);
            append = $"{firstEncryptedPart}{firstDigit}{lastDigit}{secondEncryptedPart}";
            return append;

        }

        static int GetFirstDigit(char inputChar)
        {
            int digit = 0;
            while ((int)inputChar != 0)
            {
                digit = inputChar % 10;
                inputChar = (char)(inputChar / 10);
            }
            return digit;
        }

        static int GetLastDigit(char inputChar)
        {
            int digit = 0;
            return digit = inputChar % 10;
        }
    }
}
