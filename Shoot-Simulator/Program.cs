using System;

namespace Shoot_Simulator
{
    class Gun
    {
        private int statusReload = 5;
        private int pistolClip = 5;

        public void Reload()
        {
            if (pistolClip == statusReload)
            {
                Console.WriteLine("Магазин полный!");
                return;
            }
            Console.WriteLine("Прошла перезарядка!");
            pistolClip = statusReload;
        }
        public void Shoot()
        {
            if (pistolClip == 0)
            {
                Console.WriteLine("Оружие не заряжено!");
                Reload();
                Console.WriteLine($"\nПатронов: {pistolClip}\n");
                return;
            }

            pistolClip--;
            Console.WriteLine($"Выстрел! Патронов осталось: {pistolClip}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var gun = new Gun();
            bool isStop = false;

            while (!isStop)
            {
                ConsoleKey key = Console.ReadKey().Key;

                if (key == ConsoleKey.D1)
                {
                    gun.Shoot();
                }
                else if (key == ConsoleKey.R)
                {
                    gun.Reload();
                }
                else
                {
                    isStop = true;
                }
            }
        }
    }
}
