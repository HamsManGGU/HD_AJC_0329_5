using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0329_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int i = 0;
            
            while (i<4)
            {
                for(int j = 0; j < (3-i); j++)
                {
                    Console.Write('\u2005');
                }
                
                for (int k = 0; k < i+1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}
