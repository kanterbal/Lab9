using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, numOper = 0;
            Console.WriteLine("Vas privetstvuet kaljkuljator!");
            try
            {
                Console.Write("Vvedite celoe cilso. X=");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Vvedite celoe cislo. Y=");
                y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Vvedite kod operacii:\n\t1 - slozenie\n\t2 - vjicitanie\n\t3 - proizvedenie\n\t4 - castnoe\nVas vjibor: ");
                numOper = Convert.ToInt32(Console.ReadLine());
                switch (numOper)
                {
                    case 1:
                        {
                            Console.WriteLine("Rezultat = {0}", x + y);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Rezultat = {0}", x - y);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Rezultat = {0}", x * y);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Rezultat = {0}", x / y);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Net operacii s ukazannjim nomerom");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Osibka! {0}", ex.Message);
            }
            Console.ReadKey();
        }
    }
}
