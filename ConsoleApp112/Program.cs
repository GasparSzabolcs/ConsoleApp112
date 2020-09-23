using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp112
{
    class Program
    {
        static void Main()
        {
           
            //== --> akkor igaz ha egyformák az operandusok
            //!= --> akkor igaz ha az egyik igaz a masik hamis
            //|| --> ha az 1ik aigaz akkor igaz 
            //&& --> akkor igaz h mind2o igaz 
            //int[] t = new int[10];
            //if ((t.Length == 10) == (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday))
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}


            int x = 10;
            switch (x)
            {
                case 1:
                    {
                        Console.WriteLine("ez egy ");
                        Console.WriteLine("és még további kód");
                    }
                    break;
                case 2:
                        Console.WriteLine("ez ketto, egy sorba is lehet ");
                    
                    break;

                case 5:
                    Console.WriteLine("nem kell h sorba legyen");
                    break;
                case 3:
                    Console.WriteLine("harom");
                    break;
                case 10:
                    Console.WriteLine("tiz");
                    break;
                default:
                    Console.WriteLine("akkor teljesul ha egyik sw se teljesul");
                    break;
            }


            Console.ReadKey();

        }
    }
}
