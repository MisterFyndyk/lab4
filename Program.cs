using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("   ЛАБОРАТОРНАЯ РАБОТА №4");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Номера автобусов");
            Console.WriteLine("2. Сжатие бинарных последовательностей");
            Console.WriteLine("3. Стрелки");
            Console.WriteLine("4. Нумеролог");
            Console.WriteLine("5. Перестановка");
            Console.WriteLine("0. Выход");
            Console.WriteLine("=================================");
            Console.Write("Выберите задачу (0-5): ");
            
            string choice = Console.ReadLine();
            Console.Clear();
            
            switch (choice)
            {
                case "1":
                    BusNumbers.Run();
                    break;
                case "2":
                    BinaryCompress.Run();
                    break;
                case "3":
                    Arrows.Run();
                    break;
                case "4":
                    Numerologist.Run();
                    break;
                case "5":
                    Permutation.Run();
                    break;
                case "0":
                    Console.WriteLine("Программа завершена.");
                    return;
                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
            }
            
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}