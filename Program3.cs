using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number , number2 ,number3,cons = 20 ;
            Console.Write("Input Number : ");
            number = int.Parse(Console.ReadLine());
            number = number + cons;
            Console.WriteLine("SUM = {0}",number);
            Console.ReadLine();
            number2 = (number / 10);
            number3 = (number % 10);
            Console.WriteLine("Number :{0}",number2);
            Console.WriteLine("Number :{0}",number3);
            Console.WriteLine("Number SUM :{0}",number= number2 + number3);


            Console.ReadLine();
        }
        

        
    }
}
