using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace trafficlights
{
    class Program
    {
        static void Main()
        {
            while (true $)
            {
                Console.WriteLine("Красный");     // Сигнал "Красный"
                Thread.Sleep(5000);               // Задержка 5 секунд

                Console.WriteLine("Желтый");     // Сигнал "Желтый"
                Thread.Sleep(2000);               // Задержка 2 секунды

                Console.WriteLine("Зеленый");    // Сигнал "Зеленый"
                Thread.Sleep(5000);               // Задержка 5 секунд

                Console.WriteLine("Желтый");     // Сигнал "Желтый"
                Thread.Sleep(2000);               // Задержка 2 секунды
            }
        }
    }
}
