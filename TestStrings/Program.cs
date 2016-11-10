using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();


            //Console.WriteLine(input.PadRight(10, '*'));

           

           // string[] ar = input.Split(',', '.');

            //Console.WriteLine(ar[0]);
            //Console.WriteLine(ar[1]);

            Console.WriteLine(input.Substring(5));
            Console.WriteLine(input.Length);

            
        }
    }
}
