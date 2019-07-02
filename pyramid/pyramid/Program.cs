using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, l, rows;
            Console.Write("Input rows: ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = rows - i; j > 0; j--)
                {
                    Console.Write("*");
                }
                    
            
                for (k = 1; k < i; k++)
                {
                    Console.Write("{0}", k);
                }

                for (l = i; l > 0; l--)
                {
                    Console.Write("{0}", l);
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
        
    }
}
