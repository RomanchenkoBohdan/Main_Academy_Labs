using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            #region инициализация зубчатого массива
            var Arr = new Computer[4][];
            Arr[0] = new Computer[4];
            Arr[1] = new Computer[2];
            Arr[2] = new Computer[1];
            Arr[3] = new Computer[3];

            Arr[0][0] = new Computer(PcType.desktopComputer, 256, 2.2);
            Arr[0][1] = new Computer(PcType.notebook, 128, 3.2);
            Arr[0][2] = new Computer(PcType.desktopComputer, 1024, 5.1);
            Arr[0][3] = new Computer(PcType.desktopComputer, 512, 4.6);

            Arr[1][0] = new Computer(PcType.desktopComputer, 128, 2.2);
            Arr[1][1] = new Computer(PcType.notebook, 1024, 3.2);

            Arr[2][0] = new Computer(PcType.notebook, 512, 2.2);

            Arr[3][0] = new Computer(PcType.notebook, 512, 2.2);
            Arr[3][1] = new Computer(PcType.notebook, 2048, 5.1);
            Arr[3][2] = new Computer(PcType.notebook, 1024, 5.1);
            #endregion

            int countDesktop = 0;
            int countNotebook = 0;
            int countAllPc = 0;

            // Посчест количества компьютеров
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr[i].Length; j++)
                {
                    countAllPc++;
                    if (Arr[i][j].pcType == PcType.desktopComputer)
                        countDesktop++;
                    else
                        countNotebook++;
                }
            }

            Console.WriteLine("Количество Desktop компьютеров = " + countDesktop);
            Console.WriteLine("Количество Notebook компьютеров = " + countNotebook);
            Console.WriteLine("Общее количество компьютеров = " + countAllPc + "\n");

            var maxHdd = 0;
            var positionHdd = "";

            // Посчест максимальный объём HDD
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr[i].Length; j++)
                {
                    if (Arr[i][j].memoryCapasity > maxHdd)
                    {
                        maxHdd = Arr[i][j].memoryCapasity;
                        positionHdd = $"Компьютер с максимальным объёмом HDD находится на позиции: {i} массив {j} подмассив";
                    }
                }
            }

            Console.WriteLine("Максимальный объёмом HDD = " + maxHdd);
            Console.WriteLine(positionHdd + "\n");

            double lowestProductivityCpu = 1000.0;
            int minHdd = 1000000;
            string positionWeakComputer = "";

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr[i].Length; j++)
                {
                    if (Arr[i][j].cpuClockSpeed <= lowestProductivityCpu && Arr[i][j].memoryCapasity <= minHdd)
                    {
                        lowestProductivityCpu = Arr[i][j].cpuClockSpeed;
                        minHdd = Arr[i][j].memoryCapasity;
                        positionWeakComputer = $"Компьютер с наименьшей производительностью ЦП и найменшим объёмом HDD находится на позиции: {i} массив {j} подмассив";
                    }
                }
            }

            Console.WriteLine(positionWeakComputer);
            Console.WriteLine($"В этом компьютере объём HDD = {minHdd}, а производительность ЦП = {lowestProductivityCpu}" + "\n");

            // Изменение HDD
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr[i].Length; j++)
                {
                    if (Arr[i][j].pcType == PcType.desktopComputer)
                    {
                        Arr[i][j].memoryCapasity += 8;
                    }
                    else
                    {
                        Arr[i][j].memoryCapasity = 8;
                    }
                }
            }

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr[i].Length; j++)
                {
                    if (Arr[i][j].pcType == PcType.desktopComputer)
                    {
                        Console.WriteLine($"desktopComputer под номером {i} {j} = {Arr[i][j].memoryCapasity}");
                    }
                    else
                    {
                        Console.WriteLine($"notebook под номером {i} {j} = {Arr[i][j].memoryCapasity}");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
