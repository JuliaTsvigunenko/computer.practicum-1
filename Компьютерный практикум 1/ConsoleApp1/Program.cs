using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Компьютерный практикум №1
            Console.Title = "Программа №1 (Цвигуненко Юлия)";
            Console.WriteLine("Введите свое имя:");
            string name = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Здравсвуйте, {name}");
            Console.SetWindowSize(60, 25);
            
            bool capsLockState = Console.CapsLock; /*(Операция bool-это возвращение логического значения true или false).*/
            if (capsLockState) 
            {
                Console.WriteLine($"Состояние CapsLock: включен!");
            }
            else
            {
                Console.WriteLine($"Состояние CapsLock: выключен!");
            }
            
            bool NumLock = Console.NumberLock;
            if (NumLock)
            {
                Console.WriteLine($"Состояние NumLock: включен!");
            }
            else
            {
                Console.WriteLine($"Состояние NumLock: выключен!");
            }
              Console.ReadKey();
            
            
           

            
        }
    }
}
