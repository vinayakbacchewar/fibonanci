using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fibonanci
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("1 for recursive factorial");
                Console.WriteLine("2 for Iterative factorial");
                int choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter a no");
                int no = Convert.ToInt32(Console.ReadLine());
                Program obj = new Program();
                if (obj.checkvalidno(no))
                {

                    switch (choice)
                    {
                        case 1:
                            long factorial = obj.factorialwithrecursion(no);
                            obj.printfactorial(no, factorial);
                            break;

                        case 2:
                            factorial = obj.factorialwithIteration(no);
                            obj.printfactorial(no, factorial);
                            break;

                        default:
                            Console.WriteLine("Invalid Choice");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter Valid no");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public long factorialwithIteration(int no)
        {
            long factorial=1;
            for (int i = 1; i <= no; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public void printfactorial(int no, long factorial)
        {
            Console.WriteLine("{0} factorial is {1}", no, factorial);
            Console.ReadKey();
        }
        public long factorialwithrecursion(int no)
        {
            if (no == 0)
            {
                return 1;
            }
            return no * factorialwithrecursion(no - 1);
        }

        public bool checkvalidno(int no)
        {
            if (no > 0)
                return true;
            else
                return false;
        }
    }
}
