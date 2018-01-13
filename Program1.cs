using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;
            int Choice = 0;
            double Area = 0, Base = 0, Height = 0, Wide = 0, Long = 0 , Redian = 0 ;
            int i = 1;
            while (i == 1)
            {
                Console.WriteLine("You Choose Number For Process :");
                Console.WriteLine("You Choose Number 1 For Process : Area Triangle");
                Console.WriteLine("You Choose Number 2 For Process : Area Rectangle");
                Console.WriteLine("You Choose Number 3 For Process : Area Circle ");
                Choice = int.Parse(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("You insert base :");
                        Base = double.Parse(Console.ReadLine());
                        Console.WriteLine("You insert height  :");
                        Height = double.Parse(Console.ReadLine());
                        Area = (0.5 * Base * Height);
                        Console.WriteLine("Area Triangle : {0}", Area);
                        break;
                    case 2:
                        
                        Console.WriteLine("You insert wide :");
                        Wide = double.Parse(Console.ReadLine());
                        Console.WriteLine("You insert long :");
                        Long = double.Parse(Console.ReadLine());
                        Area = (Wide * Long);
                        Console.WriteLine("Area Rectangle: {0}", Area);


                        break;
                    case 3:
                        Console.WriteLine("You insert redian :");
                        Redian = double.Parse(Console.ReadLine());
                        Area = (PI * Redian * Redian);
                        Console.WriteLine("Area Circle: {0}", Area);

                        break;
                    default:
                        Console.WriteLine("You Choose Number Invalid \n Please Choose Number Agian");

                        break;


                }

                Console.WriteLine(" Choose 1 : Program Working again \t Choose 0 : Quit Program");
                i = int.Parse(Console.ReadLine());
                if((i > 1)&&(i < 0))
                {
                    i = 0;
                }


            }
                //Console.ReadLine();
        }
        
    }
}
