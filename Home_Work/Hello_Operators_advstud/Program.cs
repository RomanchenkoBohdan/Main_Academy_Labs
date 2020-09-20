using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Operators_advstud
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MyMax = 200;

            Random rnd = new Random();
            int Guess_number = rnd.Next(0, MyMax) + 1;

            bool Comparison;
            int input = 0;
            try
            {
                do
                {
                    Console.WriteLine("Введите число");
                    input = int.Parse(Console.ReadLine());

                    if (input < Guess_number) 
                        Console.WriteLine("Ваше число меньше рандомного, попробуйте еще раз");
                    else if (input > Guess_number) 
                        Console.WriteLine("Ваше число больше рандомного, попробуйте еще раз");
                    else 
                        Console.WriteLine($"Вы угадали!!! {input} = {Guess_number}");

                    if (input == Guess_number)
                        Comparison = false;
                    else
                        Comparison = true;

                }
                while (Comparison);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
