using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SticksGame
{
    class Program
    {
        static int EnterSticksCount()
        {
            Console.WriteLine("Введите начальное количество палочек от 10 до 99:");
            int sticksCount = Convert.ToInt16(Console.ReadLine());
            return sticksCount;
        }

        static void Warning()
        {
            Console.WriteLine("Введено некорректное число.");
        }

        static void PlayerStep(int sticksCount)
        {
            Console.WriteLine("Сколько палочек ты берешь(от 1 до 3):");
            sticksCount -= Convert.ToInt16(Console.ReadLine());
            PcStep(sticksCount);
        }

        static void PcStep(int sticksCount)
        {
            int incomeCount = sticksCount;

            if (sticksCount == 5)
            {
                Console.WriteLine("Ты победил!");
            }

            if (sticksCount != 5 && sticksCount < 9 && sticksCount > 5)
            {
                sticksCount = 5;
                Console.WriteLine($"Я взял {incomeCount - sticksCount}. Осталось {sticksCount} палочек.");
                PlayerStep(sticksCount);
            }

            if (sticksCount < 5)
            {
                sticksCount = 1;
                Console.WriteLine("Ты проиграл!");
            }

            if (sticksCount > 9)
            {
                sticksCount -= 3;
                Console.WriteLine($"Я взял {incomeCount - sticksCount}. Осталось {sticksCount} палочек.");
                PlayerStep(sticksCount);
            }
        }

        static void Main(string[] args)
        {
            int sticksCount = EnterSticksCount();
            if ((sticksCount > 99) || (10 > sticksCount))
            {
                Warning();
            }
            PlayerStep(sticksCount);
            PcStep(sticksCount);

            Console.ReadKey();
        }
    }
}
