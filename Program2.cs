using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            double sum ,sum2;
            Console.WriteLine("Input num1 : ");
            num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Input num2 : ");
            num2 = double.Parse(Console.ReadLine());

                    sum = (num1 / num2);
                Console.WriteLine("(num1 / num2) = {0} Round", sum);


            sum = Math.Pow(sum, 2);
            Console.WriteLine("(num1 / num2)^2 = {0}", sum);



            sum2 = num1 % num2;
            Console.WriteLine("(num1 / num2) Remnant = {0}", sum2);


            sum2 = Math.Sqrt(sum2);
            Console.WriteLine("(num1 / num2) Sqrt(2) = {0}", sum2);


            Console.ReadLine();

        }
    }
}
