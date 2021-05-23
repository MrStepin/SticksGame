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
            int sticksCount = Convert.ToInt32(Console.ReadLine());
            return sticksCount;
        }

        static void Warning()
        {
            Console.WriteLine("Введено некорректное число.");
        }

        static void PlayerStep(int sticksCount)
        {
            Console.WriteLine("Сколько палочек ты берешь(от 1 до 3):");
            if (Convert.ToInt32(Console.ReadLine()) < 4 && Convert.ToInt32(Console.ReadLine()) > 0)
            {
                sticksCount -= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Осталось {sticksCount} палочек.");
                PcStep(sticksCount);
            }
            else
            {
                Console.WriteLine("Столько нельзя брать. Возьми 1(ОДНУ) 2(ДВЕ) или 3(ТРИ).");
                PlayerStep(sticksCount);
            }
        }

        static void PcStep(int sticksCount)
        {
            int incomeCount = sticksCount;

            if (sticksCount == 5)
            {
                Console.WriteLine("Ты победил!");
            }

            if (sticksCount > 5)
            {
                sticksCount = sticksCount - ((sticksCount - 1) % 4);
                Console.WriteLine($"Я взял {incomeCount - sticksCount}. Осталось {sticksCount} палочек.");
                PlayerStep(sticksCount);
            }

            if (sticksCount < 5)
            {
                sticksCount = 1;
                Console.WriteLine("Ты проиграл!");
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
