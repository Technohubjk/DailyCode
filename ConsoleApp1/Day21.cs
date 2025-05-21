using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Day21
    {
        public void IsPlaindrom()
        {
            string str = "NAMAN";
            int i = 0;
            int j = str.Length - 1;
            bool IsPalindrom = true;
            while (i < j)
            {
                if (str[i] != str[j])
                {
                    IsPalindrom = false;
                    Console.WriteLine("This is not Palindrom string");
                    break;
                }
                i++;
                j--;
               
            }
            if (IsPalindrom)
            {
                Console.WriteLine("This is Palindrim String " + str);

            }
        }
        public void NumPalindrom()
        {
            int ASN = 1021;
            int ntem = ASN, R;
            int DSN = 0;
            while (ASN != 0)
            {
                R = ASN % 10;
                DSN = DSN * 10 + R;
                ASN = ASN / 10;
            }
            
            if (ntem == DSN)
            {
                Console.WriteLine("This a Palindrom Number"+ntem);
            }
            else
            {
                Console.WriteLine("This is Not Palindrom Num");
            }
        }
       public bool IsPrimeNum()
        {
            int n = 22;
            if (n < 2)
            {
                return false;
            }
            for(int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("This is not Prime Num");
                    return false;
                    
                }
               
            }
            Console.WriteLine("Yes");
            return true;
           
        }
        public void ShiftZero()
        {
            int[] arr = { 1, 3, 2, 0, 5, 0, 4, 0, 8, 0, 5, 5 };
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

        public void BinarSearch()
        {
            int[] arr = { 2, 1, 0, 4, 2, 9 };
            int target = 4;
            int left = 0;
            int Right = arr.Length - 1;
            Array.Sort(arr);
            while (left <= Right)
            {
                int mid = left + (Right - left) / 2;
                if (arr[mid] ==target)
                {
                    Console.WriteLine("Goted..."+arr);
                    return;
                }
                if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                if (arr[mid] > target)
                {
                    Right = mid - 1;
                }
               
            }
            Console.WriteLine("Not Founded the target Value");
        }
    }
}
