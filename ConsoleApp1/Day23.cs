using System;
using System.Collections.Generic;
using System.Text;

namespace DailyCodePractice
{
    class Day23
    {
        public void LUTri()
        {
            for(int i = 1; i < 10; i++)
            {
                for(int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void LeftLowerTri()
        {
            for(int i = 10; i >= 1; i--)
            {
                for(int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void RUTri()
        {
            for(int i = 1; i <=10; i++)
            {
                for(int j = 0; j < 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void RightLTri()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j < 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int i = 9; i >=1; i--)
            {
                for (int j = 0; j < 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }

        public void RevserString()
        {
            string str = "SHIVKUMAR";
            string R = " ";
            //foreach (var item in str)
            //{
            //    R = R + item;
            //}
            for(int i = str.Length - 1; i >= 1; i--)
            {
                R = R + str[i];
            }
            Console.WriteLine(R);
        }

        public void Vowls()
        {
            string str = "SHIV KUMAR";
            string V = "aeiouAEIOU";
            string R = " ";
            int count = 0;
            foreach(var item in str)
            {
                if (V.Contains(item))
                {
                    R = R + item;
                    count++;
                }
            }
            Console.WriteLine(R+ " "+ count);
        }
        public void Fibonic()
        {
            int n = 5;
            int a = 0;
            int b = 1;
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(a + " ");
                int c = a + b;
                a = b;
                b = c;
            }
        }
        public void ShiftZeroToEnd()
        {
            int[] arr = { 0,1, 2, 1 };
            int index = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[index++] = arr[i];

                }
            }
            while (index < arr.Length)
            {
                arr[index++] = 0;
            }
            Console.WriteLine(arr);
        }
        public void NonReapting()
        {
            string str = "swiss";
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach(char c in str)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
            // Step 2: Find the first non-repeating character
            foreach(char c in str)
            {
                if (charCount[c] == 1)
                {
                    Console.WriteLine("Yes"+c);
                    return;
                }
            }
            Console.WriteLine("No non-repeating character found.");
        }
        public void Fact()
        {
            int n = 5;
            int r = 1;
            for(int i = 2; i <= n; i++)
            {
                r = r * i;
            }
            Console.WriteLine(r);
        }
        public void SecondHighest()
        {
            int[] arr = { 2, 3, 1, 4 };
            int first = int.MinValue, second = int.MinValue, third = int.MinValue;
            foreach (var item in arr)
            {
                if (item > first)
                {
                    third = second;
                    second = first;
                    first = item;
                }
                else if(item>second && item < first)
                {
                    third = second;
                    second = item;

                }
                else if(item>third && item < first)
                {
                    third = item;
                }
            }
            Console.WriteLine(third);

        }
        // int[] arr={1,2,3,4,5}
        // int targer=7
        public void SubArray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int target = 3;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++) 
                {
                    if (arr[i] + arr[j] == target)
                    {
                        Console.WriteLine($"Sum of Elements{target} index {i} and {j}");
                       // Console.WriteLine($"Sum of Elements {target} = {arr[i]} + {arr[j]} at index {i} and {j}");
                    }
                   
                }
            }

        }
    }
}
