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
    }
}
