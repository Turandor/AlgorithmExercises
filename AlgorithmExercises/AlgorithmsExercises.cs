using System;
using System.Collections.Generic;
using System.Threading;

namespace AlgorithmExercises
{
    /* Algoritgm exercises from:
     * https://www.w3resource.com/csharp-exercises/basic-algo/index.php 
     */

    public static class Algorithms
    {
        static void Main(string[] args)
        {
            string str = "abcd";


            Console.WriteLine(Algorithms.Seventh(str));
        }

        /*  1.
         *  Write a C# Sharp program to compute the sum of the two given integer values.
         *  If the two values are the same, then return triple their sum. 
         */
        public static int First(int a, int b)
        {
            if (a != b)
                return a + b;
            else
                return (a + b) * 3;
        }

        /*  2.
         *  Write a C# Sharp program to get the absolute difference between n and 51.
         *  If n is greater than 51 return triple the absolute difference.
         */
        public static int Second(int n)
        {
            if (n > 51)
                return Math.Abs(n - 51) * 3;
            else
                return Math.Abs(n - 51);
        }

        /* 3.
         * Write a C# Sharp program to check two given integers,
         * and return true if one of them is 30 or if their sum is 30.
         */
        public static bool Third(int a, int b)
        {
            if (a == 30 || b == 30)
                return true;
            else if (a + b == 30)
                return true;
            else
                return false;
        }

        /* 4.
         * Write a C# Sharp program to check a given integer
         * and return true if it is within 10 of 100 or 200.
         */
        public static bool Fourth(int a)
        {
            if (a >= 90 && a <= 110 || a >= 190 && a <= 210)
                return true;
            else
                return false;          
        }

        /* 5.
         * Write a C# Sharp program to create a new string where 'if' is added to the front of a given string.
         * If the string already begins with 'if', return the string unchanged.
         */
        public static string Fifth(string str)
        {
            if (str.StartsWith("if"))
                return str;
            else
                return "if " + str;
        }

        /* 6.
         * Write a C# Sharp program to remove the character in a given position of a given string.
         * The given position will be in the range 0.. string length -1 inclusive.
         */
        public static string Sixth(string str, int n)
        {
            return str.Remove(n,1);
        }

        /* 7.
         * Write a C# Sharp program to exchange the first and last characters
         * in a given string and return the new string
         */
        public static string Seventh(string str)
        {
            if (str.Length >= 2)
            {
                char tmp1 = str[0];
                char tmp2 = str[str.Length - 1];
                if (str.Length > 2)
                {
                    str = str.Substring(1, str.Length - 2);
                    return tmp2 + str + tmp1;
                }
                else
                    return tmp2.ToString() + tmp1;
            }
            else
                return str;

        }

        /* 8.
         * Write a C# Sharp program to create a new string which is
         * 4 copies of the 2 front characters of a given string.
         * If the given string length is less than 2 return the original string.
         */
        public static string Eighth(string str)
        {
            if (str.Length >= 2)
            {
                string tmp = str.Substring(0, 2);
                return tmp + tmp + tmp + tmp;
            }
            else
                return str;
        }

        /* 9.
         * Write a C# Sharp program to create a new string with the last
         * char added at the front and back of a given string of length 1 or more. 
         */
        public static string Ninth(string str)
        {
            if (str.Length >= 1)
            {
                char tmp = str[str.Length-1];
                return tmp + str + tmp;
            }
            else
                return str;
        }

        /* 10.
         * Write a C# Sharp program to check if a given positive number
         * is a multiple of 3 or a multiple of 7.
         */
        public static bool Tenth(int n)
        {
            if (n % 3 == 0 || n % 7 == 0)
                return true;
            else
                return false;
        }

        /* 11. 
         * Write a C# Sharp program to create a new string taking
         * the first 3 characters of a given string and return the string
         * with the 3 characters added at both the front and back.
         * If the given string length is less than 3, use whatever characters are there.
         */
        public static string Eleventh(string str)
        {
            string tmp;

            if (str.Length > 0)
            {
                if (str.Length < 3)
                    tmp = str.Substring(0, str.Length);
                else
                    tmp = str.Substring(0, 3);
                return tmp + str + tmp;
            }
            return str;
        }

        /* 12. 
         * Write a C# Sharp program to check if a given string starts with 'C#' or not.
         */
        public static bool Twelfth(string str)
        {
            if (str.StartsWith("C#"))
                return true;
            else
                return false;
        }

        /* 13.
         * Write a C# Sharp program to check if one given temperatures is less than 0
         * and the other is greater than 100.
         */
        public static bool Thirteenth(int a, int b)
        {
            if ((a < 0 && b > 100) || (b < 0 && a > 100))
                return true;
            else
                return false;
        }

        /* 14.
         * Write a C# Sharp program to check two given integers whether
         * either of them is in the range 100..200 inclusive.
         */
        public static bool Fourteenth(int a, int b)
        {
            if (a >= 100 && b >= 100 &&
                a <= 200 && b <= 200)
                return true;
            else
                return false;
        }

        /* 15.
         * Write a C# Sharp program to check whether three given integer values
         * are in the range 20..50 inclusive. Return true if 1 or more of them
         * are in the said range otherwise false.
         */
        public static bool Fifteenth(int a, int b, int c)
        {
            if ((a >= 20 && a <= 50) ||
                (b >= 20 && b <= 50) ||
                (c >= 20 && c <= 50))
                return true;
            else
                return false;
        }

        /* 147.
         * Write a C# Sharp program to create a new list from a given list
         * of strings where strings will be in upper case in new string.
         */
        public static List<string> HundredFortySeventh(List<string> str)
        {
            for (int i = 0; i < str.Count; i++)
            {
                str[i] = str[i].ToUpper();
            }
            return str;
        }

        /* 148.
         * Write a C# Sharp program to remove all "a" in each string in
         * given list of strings and return the new string.
         */
        public static List<string> HundredFortyEighth(List<string> str)
        {
            for (int i = 0; i < str.Count; i++)
            {
                str[i] = str[i].Replace("a", "");
            }
            return str;
        }

        /* 150.
         * Write a C# Sharp program to create a new list from a given list
         * of integers removing those values end with 7.
         */
        public static List<int> HundredFifth(int[] a)
        {
            List<int> tmp = new List<int>();
            
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 10 != 7)
                    tmp.Add(a[i]);
            }
            return tmp;
        }
    }
}
