using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyCodePractice
{
    class Day22
    {
       // a=10;
       // b=12;
       // result a=12, b=10 without using any thid variable
       public void SwapNum()
        {
            int a, b;
            a = 10;
            b = 12;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"This is a :{a}");
            Console.WriteLine($"This is b :{b}");

        }
        public void FibonicSerise()
        {
            int a = 0;
            int b = 1;
            int c;
            for(int i = 0; i <= 6; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write(c+" ");
            }
           
        }
        public bool IsPrimeNum()
        {
            int n = 2;
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
            Console.WriteLine("Yes this is Prime"+n);
            return true;
        }
        public void ALLPrimNum()
        {
            int n = 12;
            bool isPrim = true;
            for(int i = 0; i <= n; i++)
            {
                for(int j = 2; j <= n; j++)
                {
                    if(i!=j && i % j == 0)
                    {
                        isPrim = false;
                        break;

                    }
                }
                if (isPrim)
                {
                    Console.Write(i+" ");
                }
                isPrim = true;
            }
        }

        public void RemoveDublicatArray()
        {
            int[] arr = { 1, 2, 2, 2, 3, 4, 5 };
            int[] Unique = arr.Distinct().ToArray();
            Console.WriteLine("After Removing Dublicatie");
            foreach (int item in Unique)
            {
                Console.Write(item + " ");
            }
        }
        public void SkipDublicate()
        {
            int[] arr = { 1, 3, 3, 3, 4, 4, 4, 4, 55, 55, 6, 7, 88, 88 };
            int n = arr.Length;
            for(int i = 0; i < n; i++)
            {
                bool IsDublicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        IsDublicate = true;
                        break;
                    }
                }
                if (!IsDublicate)
                {
                    Console.WriteLine(arr[i]+" ");
                }
            }
           
        }

        public void NumPalindrom()
        {
            int n = 121;
            int ntem = n,rem,rev=0;
            while (n > 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            //return ntem == rev;
            if (ntem == rev)
            {
                Console.WriteLine($"This is Palindrom num "+ ntem);
            }
            else
            {
                Console.WriteLine($"This is not Palindrom num");
            }

        }

        public void StringPalindrom()
        {
            string str = "NAASMAN";
            int i = 0;
            int j = str.Length - 1;
            bool isPalindrom = true;
            while (i < j)
            {
                if (str[i] != str[j])
                {
                    Console.WriteLine("Not "+str);
                    break;

                }
                i++;
                j--;

            }
            if (isPalindrom)
            {
                Console.WriteLine("This is Palindrom String "+ str);
            }
        }
        public void Reverse()
        {
            string str = "SHIV";
            string R = " ";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                R = R + str[i];
            }
            Console.WriteLine(R);
        }
        public void RevNum()
        {
            int ASN = 1234;
            int DSN = 0;
            int R;
            int n = ASN;
            while (ASN != 0)
            {
                R = ASN % 10;
                DSN = DSN * 10 + R;
                ASN = ASN / 10;
            }
            Console.WriteLine(DSN);
        }
        public void AddDigit()
        {
            int N = 123;
            int S = 0;
            int R;
            while (N != 0)
            {
                R = N % 10;
                N = N / 10;
                S = S + R;
            }
            Console.WriteLine(S);
                
        }

       public void SumArray()
        {
            int[] arr = { 1, 3, 5 };
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Array.Reverse(arr);
            Console.WriteLine(arr);
            Console.WriteLine(sum);
        }
       public void Vowels()
        {
            string str = "SHIV KUMAR";
            string Vowels = " ";
            int count = 0;
            string VSet = "aeiouAEIOU";
            foreach(var item in str)
            {
                if (VSet.Contains(item))
                {
                    Vowels = Vowels + item;
                    count++;
                }
            }
            Console.WriteLine(Vowels + " "+count);

        }
        public void ShiftZero()
        {
            int[] arr = { 0, 4, 0, 2, 0, 4, 5, 6, 7, 2 };
            int index = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[index++] = arr[i];
                }
            }
            while(index < arr.Length)
            {
                arr[index++] = 0;
            }
            Console.WriteLine("Outpur"+string.Join(",",arr));
        }
        public void Binary()
        {
            int[] arr = { 1, 4, 3, 7, 0,5 };
            int target = 7;
            Array.Sort(arr);
            int left = 0;
            int Right = arr.Length - 1;
            while (left <= Right)
            {
                int mid = left + (Right - left) / 2;
                if (arr[mid] == target)
                {
                    
                    Console.WriteLine($"Index{mid} ANd "+arr[mid]);
                    Console.WriteLine("After Sort the Array" + string.Join(",", arr));
                    return;
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    Right = mid - 1;
                }
            }
            Console.WriteLine("NOt Founded");
        }
        public void DublicatePair()
        {
            int[] arr = { 1, 2, 3, 2,3,44,44 };
            int sum = 47;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    //if (arr[i] == arr[j])
                    //{
                    //    Console.WriteLine(" " + arr[i]);
                    //    break;
                    //}
                    //  Console.WriteLine($"({arr[i]},{arr[j]})");

                    if (arr[i] + arr[j] == sum)
                    {
                        Console.WriteLine($"Sum of Two Array {sum},{arr[i]},{arr[j]}");
                    }
                }
            }
        }
        public void Tringle()
        {
            for(int i = 6; i >=1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }

        public void LeftUpper()
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= i; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }

    }
}
