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
    }
}
