using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, sum;
            Console.WriteLine("Input num1 : ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input num2 : ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input num3 : ");
            num3 = int.Parse(Console.ReadLine());

            sum = num1 + num2 + num3;
            Console.WriteLine("SUM TOTAL = {0}", sum);

            num1 = (num1 * num1);
            num2 = (num2 * num2);
            num3 = (num3 * num3);
            Console.WriteLine("SUM TOTAL = {0}", num1 + num2 + num3);


            Console.ReadLine();

        }
    }
}
