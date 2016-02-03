using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoEuclides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite primeiro numero (a)");

            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo numero (b)");

            int b = Int32.Parse(Console.ReadLine());


            bool divZero = false;

            int r = a % b;

            Console.WriteLine(r);

            int r1 = 0;

            if (r > 0)
            {
               r1 = b % r;
              Console.WriteLine(r1);
            }
            else
            {
                divZero = true;
            }

            int r2 = r;
            int r3 = r1;

            while (divZero != true)
            {
                if (r3 > 0)
                {
                    r2 = r2 % r3;
                    Console.WriteLine(r2);
                }
                    
                else
                    divZero = true;

                

                if (r2 > 0)
                {
                    r3 = r3 % r2;
                    Console.WriteLine(r3);
                }
                    
                else
                    divZero = true;

                
            }

            if(r == 0)
            {
                Console.WriteLine("O MMC = " + b);
            }
            else if(r2 == 0)
            {
                Console.WriteLine("O MMC = " + r3);
            }
            
            



            Console.Write("Precione uma batão para  continuar...");
            Console.ReadKey();
        }
    }
}
