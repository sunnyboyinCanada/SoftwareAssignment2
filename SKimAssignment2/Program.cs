using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKimAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            int menu = 0;
            List<int> sides = new List<int>();

            while (menu != 2)
            {
                Console.Clear();
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit\n");

                while (!int.TryParse(Console.ReadLine(), out menu) || menu <= 0 || menu > 2)
                {
                    Console.WriteLine("\nEnter a Right Number!");
                }
                Console.WriteLine();

                int result = 0;
                switch (menu)
                {
                    case 1:
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"Enter integer {i}:");

                            while (true)
                            {
                                if (int.TryParse(Console.ReadLine(), out result))
                                {
                                    sides.Add(result);
                                    Console.WriteLine();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("It must be a interger that inside of the range (NUMBER > 0)");
                                    
                                }
                            }
                        }
                        Console.WriteLine(TriangleSolver.Analyze(ref sides));
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
