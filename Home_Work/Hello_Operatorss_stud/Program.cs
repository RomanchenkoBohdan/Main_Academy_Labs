using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Operatorss_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factirial calculation
            ");

            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        static void Farmer_puzzle()
        {
            int n1, n2, n3, n4, n5, n6, n7 = 0;
            int m1 = 3, m2 = 8, k3 = 1, l3 = 2, m4 = 7, k5 = 2, l5 = 1, m6 = 8, m7 = 3;
            bool flag;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"From one bank to another should carry a wolf, goat and cabbage. 
At the same time can neither carry nor leave together on the banks of a wolf and a goat, 
a goat and cabbage. You can only carry a wolf with cabbage or as each passenger separately. 
You can do whatever how many flights. How to transport the wolf, goat and cabbage that all went well?");
            Console.WriteLine("There: farmer and wolf - 1");
            Console.WriteLine("There: farmer and cabbage - 2");
            Console.WriteLine("There: farmer and goat - 3");
            Console.WriteLine("There: farmer  - 4");
            Console.WriteLine("Back: farmer and wolf - 5");
            Console.WriteLine("Back: farmer and cabbage - 6");
            Console.WriteLine("Back: farmer and goat - 7");
            Console.WriteLine("Back: farmer  - 8");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please,  type numbers by step ");
            n1 = int.Parse(Console.ReadLine());
            if (n1 == m1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please,  type next number");
                n2 = int.Parse(Console.ReadLine());

                if (n2 == m2)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Please,  type next number");
                    n3 = int.Parse(Console.ReadLine());

                    flag = (n3 == k3) | (n3 == l3);
                    if (flag)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Please,  type next number");
                        n4 = int.Parse(Console.ReadLine());

                        if (n4 == m4)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Please,  type next number");
                            n5 = int.Parse(Console.ReadLine());
                            flag = ((n5 == k5) & (n3 == k3)) | ((n5 == l5) & (n3 == l3));

                            if (flag)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Please,  type next number");
                                n6 = int.Parse(Console.ReadLine());

                                if (n6 == m6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Please,  type next number");
                                    n7 = int.Parse(Console.ReadLine());

                                    if (n7 == m7)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Success :)");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Failure :(");
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Failure :(");
                                }
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Failure :(");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Failure :(");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Failure :(");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failure :(");
            }

        }
        #endregion

        #region calculator
        static void Calculator()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"Select the arithmetic operation:
1. Multiplication 
2. Divide 
3. Addition 
4. Subtraction
5. Exponentiation ");

            int select = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter two numbers with which we will perform a mathematical operation");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = 0;
            switch (select)
            {
                case 1:
                    {
                        c = a * b;
                        Console.WriteLine($"{a} * {b} = " + c);
                        break;
                    }
                case 2:
                    {
                        c = a / b;
                        Console.WriteLine($"{a} / {b} = " + c);
                        break;
                    }
                case 3:
                    {
                        c = a + b;
                        Console.WriteLine($"{a} + {b} = " + c);
                        break;
                    }
                case 4:
                    {
                        c = a - b;
                        Console.WriteLine($"{a} - {b} = " + c);
                        break;
                    }
                case 5:
                    {
                        c = Math.Pow(a, b);
                        Console.WriteLine($"{a} ^ {b} = " + c);
                        break;
                    }
                default:
                    Console.WriteLine("You have selected an incorrect mathematical operation");
                    break;
            }
        }
        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
            Console.Write("Enter the number: ");
            int a = int.Parse(Console.ReadLine());
            int f = 1;

            for (int i = a; i > 1; i--)
            {
                f = f * i;
            }

            Console.WriteLine($"\nFactorial {f} = " + f);
        }
        #endregion
    }
}
