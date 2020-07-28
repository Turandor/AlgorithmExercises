using System;
using System.Threading;

namespace AlgorithmExercises
{
    /* Algoritgm exercises from:
     * https://www.w3resource.com/csharp-exercises/basic-algo/index.php 
     */

    class AlgorithmExercises
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /*  1.
         *  Write a C# Sharp program to compute the sum of the two given integer values.
         *  If the two values are the same, then return triple their sum. 
         */
        int First(int a, int b)
        {
            if (a != b)
                return a + b;
            else
                return a * 3;
        }

        /*  2.
         *  Write a C# Sharp program to get the absolute difference between n and 51.
         *  If n is greater than 51 return triple the absolute difference.
         */
        int Second(int n)
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
        bool Third(int a, int b)
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
        bool Fourth(int a)
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
        string Fifth(string str)
        {
            if (str.StartsWith("if"))
                return str;
            else
                return "if " + str;
        }
    }
}
