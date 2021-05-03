using System;
using System.Text.RegularExpressions;

namespace Encoder
{
    public class EncoderProcessor
    {

        public static string Consonants(char[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 97 && s[i] <= 122 && s[i] != 'y')
                {
                    s[i] = (char)(s[i] - 1);

                }
                //replacing Y
                else if (s[i] == 'y')
                {
                    s[i] = ' ';
                }
                //replacing spaces
                else if (s[i] == ' ')
                {
                    s[i] = 'y';
                }
            }
            return String.Join("", s);
        }
        public static string stringReverseString1(string str)
        {
            char[] chars = str.ToCharArray();
            char[] result = new char[chars.Length];
            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                result[i] = chars[j];
            }
            return new string(result);
        }
        public static string ReverseIntegers(string s)
        {
            string[] numbers = Regex.Split(s, @"\D+");
            foreach (string value in numbers)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    string reverse = stringReverseString1(value);
                    s = s.Replace(value, reverse);
                }
            }

            return s;
        }
        public string Encode(string message)
        {
            string messageAfReverse = ReverseIntegers(message);

            string mesage1 = messageAfReverse.ToLower().Replace('a', '1')
            .Replace('e', '2').Replace('i', '3').Replace('o', '4').Replace('u', '5');

            string messageAftCon = Consonants(mesage1.ToCharArray());

            return messageAftCon;
        }
    }
}