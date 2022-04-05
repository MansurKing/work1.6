using System;

namespace work1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int money;
            int crystalsCount;
            int crystalsPrice = 100;

            Console.WriteLine($"Здравствуйте, вы находитель на шахтерской лавке, которая дает возможность обменять " +
                "ваше золото на драгоценные кристаллы!");
            Console.WriteLine($"Только сегодня, именно для вас кристаллы по {crystalsPrice} золота.");
            Console.Write($"Введите кол-во золота в вашем кошельке: ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Какое кол-во кристалов вы хотите купить: ");
            crystalsCount = Convert.ToInt32(Console.ReadLine());

            money -= crystalsCount * crystalsPrice;
            Console.WriteLine($"У вас в кошильке осталось {money} золота, а также {crystalsCount} кристаллов");
        }
    }
}
