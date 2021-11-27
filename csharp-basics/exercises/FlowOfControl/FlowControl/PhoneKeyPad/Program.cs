using System;
using System.Security.Cryptography.X509Certificates;

namespace PhoneKeyPad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you message");
            var inputMessage = Console.ReadLine()?.ToUpper().ToCharArray();
            MessageToNumber(inputMessage);
        }
        public static void MessageToNumber(char[] input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals('A'))
                {
                    result += "2";
                }
                else if (input[i].Equals('B'))
                {
                    result += "22";
                }
                else if (input[i].Equals('C'))
                {
                    result += "222";
                }
                else if (input[i].Equals('D'))
                {
                    result += "3";
                }
                else if (input[i].Equals('E'))
                {
                    result += "33";
                }
                else if (input[i].Equals('F'))
                {
                    result += "333";
                }
                else if (input[i].Equals('G'))
                {
                    result += "4";
                }
                else if (input[i].Equals('H'))
                {
                    result += "44";
                }
                else if (input[i].Equals('I'))
                {
                    result += "444";
                }
                else if (input[i].Equals('J'))
                {
                    result += "5";
                }
                else if (input[i].Equals('K'))
                {
                    result += "55";
                }
                else if (input[i].Equals('L'))
                {
                    result += "555";
                }
                else if (input[i].Equals('M'))
                {
                    result += "6";
                }
                else if (input[i].Equals('N'))
                {
                    result += "66";
                }
                else if (input[i].Equals('O'))
                {
                    result += "666";
                }
                else if (input[i].Equals('P'))
                {
                    result += "7";
                }
                else if (input[i].Equals('Q'))
                {
                    result += "77";
                }
                else if (input[i].Equals('R'))
                {
                    result += "777";
                }
                else if (input[i].Equals('S'))
                {
                    result += "7777";
                }
                else if (input[i].Equals('T'))
                {
                    result += "8";
                }
                else if (input[i].Equals('U'))
                {
                    result += "88";
                }
                else if (input[i].Equals('U'))
                {
                    result += "888";
                }
                else if (input[i].Equals('W'))
                {
                    result += "9";
                }
                else if (input[i].Equals('X'))
                {
                    result += "99";
                }
                else if (input[i].Equals('Y'))
                {
                    result += "999";
                }
                else if (input[i].Equals('Z'))
                {
                    result += "9999";
                }
            }
            Console.WriteLine(result);
        }
    }
}