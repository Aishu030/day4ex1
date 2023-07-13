using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //day04
            //exercise 01
            int pre, final;
            Console.WriteLine("Enter pre mark");
            pre = int.Parse(Console.ReadLine());
         
            if(pre >60)
            {
                Console.WriteLine("Enter marks in final");
                final = int.Parse(Console.ReadLine());

                if(final > 55)
                {
                    Console.WriteLine("Selected");
                }
                else
                {
                    Console.WriteLine("Fail in final");
                }
            }
            else
            {
                Console.WriteLine("Fail in pre");
            }
            Console.ReadKey();
        }
    }
}
