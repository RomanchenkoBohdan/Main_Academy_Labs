using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laba_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            try
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(@"Please,  type the number:
                    1.  f(a,b) = |a-b| (unary)
                    2.  f(a) = a (binary)
                    3.  music
                    4.  morse sos
          
                    ");
                    try
                    {
                        a = (int)uint.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 1:
                                My_strings();
                                Console.WriteLine("");
                                break;
                            case 2:
                                My_Binary();
                                Console.WriteLine("");
                                break;
                            case 3:
                                My_music();
                                Console.WriteLine("");
                                break;
                            case 4:
                                Morse_code();
                                Console.WriteLine("");
                                break;
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error" + e.Message);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #region ToFromBinary
        static void My_Binary()
        {
            int num;
            Console.Write("Введите целое число: ");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Ошибка ввода! Введите целое число: ");
            }

            int temp = 0;

            List<int> tempList = new List<int>();

            while (num != 0)
            {
                temp = num % 2;
                num = num / 2;
                tempList.Add(temp);
            }

            tempList.Reverse();

            for (int i = 0; i < tempList.Count; i++)
            {
                Console.Write(tempList[i]);
            }

        }
        #endregion

        #region ToFromUnary
        static void My_strings()
        {
            int Bin = 0;
            string dec = "";
        }
        #endregion

        #region My_music
        static void My_music()
        {
            //HappyBirthday
            Thread.Sleep(2000);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(330, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(2642, 500);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 250);
            Thread.Sleep(125);
            Console.Beep(352, 125);
            Thread.Sleep(125);
            Console.Beep(330, 500);
            Thread.Sleep(125);
            Console.Beep(297, 1000);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
        }
        #endregion

        #region Morse
        static void Morse_code()
        {
            Console.WriteLine();
            string sos = "sos";

            string[,] Dictionary_arr = new string[,] { { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" },
            { ".-   ", "-... ", "-.-. ", "-..  ", ".    ", "..-. ", "--.  ", ".... ", "..   ", ".--- ", "-.-  ", ".-.. ", "--   ", "-.   ", "---  ", ".--. ", "--.- ", ".-.  ", "...  ", "-    ", "..-  ", "...- ", ".--  ", "-..- ", "-.-- ", "--.. ", "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----." }};

            char[] Arr = sos.ToCharArray();
            string[] ArrStr = (from c in Arr select c.ToString()).ToArray();
            int s = 0;
            int o = 0;

            for (int i = 0; i < ArrStr.Length; i++)
            {
                for (int j = 0; j < Dictionary_arr.Length/2; j++)
                {
                    if (Dictionary_arr[0, j] == ArrStr[0] || Dictionary_arr[0, j] == ArrStr[2])
                    {
                        Console.Beep(1000, 250);
                        Thread.Sleep(50);
                        Console.WriteLine(Dictionary_arr[0, j]); // У меня ноут не воспроизводит эти звуки. Что бы убедится в корректности, я вывожу символы на экран
                        s++;
                        if (s == 2)
                        {
                            break;
                        }
                    }
                    else if (Dictionary_arr[0, j] == ArrStr[1] && s != 0 && o == 0)
                    {
                        Console.Beep(1000, 750);
                        Thread.Sleep(50);
                        Console.WriteLine(Dictionary_arr[0, j]); // У меня ноут не воспроизводит эти звуки. Что бы убедится в корректности, я вывожу символы на экран
                        o++;
                        break;
                    }
                }
            }
        }

        #endregion
    }
}
