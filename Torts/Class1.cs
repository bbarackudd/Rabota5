using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Torts
{
    internal class Tort
    {
        string[] zakaz = new string[7];
        int[] price = new int[7];
        SubTort tort = new SubTort();
        SubTort subtort = new SubTort();

        public  Tort()
        {
            int stop = 0;
            int pos = 1;
            DateTime data = new DateTime();
            while (stop != 1)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Собирите свой тортек:");
                Console.WriteLine("  Размер");
                Console.WriteLine("  Форма");
                Console.WriteLine("  Вкус");
                Console.WriteLine("  Коржи");
                Console.WriteLine("  Глаузрь");
                Console.WriteLine("  Топпинг");
                Console.WriteLine("  Декор");
                Console.WriteLine("  Заказать");
                Console.WriteLine($"Полный заказ:{zakaz[0]}, {zakaz[1]}, {zakaz[2]}, {zakaz[3]}, {zakaz[4]}, {zakaz[5]}, {zakaz[6]}");
                Console.WriteLine($"Цена вашего торта: {tort.price}р");


                Console.SetCursorPosition(0, pos);
                Console.Write("■");
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(0, pos++);
                        if (pos == 9)
                        {
                            pos = 8;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(0, pos--);
                        if (pos == 0)
                        {
                            pos = 1;
                        }
                        break;
                    case ConsoleKey.Enter:

                        if (pos == 1)
                        {
                            Razmer();
                        }
                        if (pos == 2)
                        {
                            Forma();
                        }
                        if (pos == 3)
                        {
                            Vkus();
                        }
                        if (pos == 4)
                        {
                            Korji();
                        }
                        if (pos == 5)
                        {
                            Glazur();
                        }
                        if (pos == 6)
                        {
                            Topping();
                        }
                        if (pos == 7)
                        {
                            Dekor();
                        }
                        if (pos == 8)
                        {
                            File.AppendAllText("C:\\source\\repos\\Pract5\\Torts\\Zakaz.txt", $"\nЗаказ от {DateTime.Now}\n\tПолная цстоимость: {tort.price}руб.\nТорт:\nРазмер: {zakaz[0]}\nФорма: {zakaz[1]}\nВкус: {zakaz[2]}");
                            EndZakaz();
                        }
                        break;
                    case ConsoleKey.Escape:
                        stop++;

                        break;
                }


            }
        }
        private void Razmer()
        {



            int stop = 0;
            int pos = 1;
            while (stop != 1)
            {

                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выберите размер тортика:");
                Console.WriteLine("  Маленький 10см +50р ");
                Console.WriteLine("  Средний 20см +100р");
                Console.WriteLine("  Большой 30см +150р");
                tort.price = price[0] + price[1] + price[2] + price[3] + price[4] + price[5] + price[6];
                Console.WriteLine($"Цена вашего торта: {tort.price}р");
                Console.SetCursorPosition(0, pos);
                Console.Write("■");
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(0, pos++);
                        if (pos == 4)
                        {
                            pos = 3;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(0, pos--);
                        if (pos == 0)
                        {
                            pos = 1;
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (pos == 1)
                        {
                            subtort.price = 50;
                            price[0] = subtort.price;
                            zakaz[0] = ("Маленький");

                        }
                        if (pos == 2)
                        {
                            subtort.price = 100;
                            price[0] = subtort.price;
                            zakaz[0] = ("Средний");



                        }
                        if (pos == 3)
                        {
                            subtort.price = 150;
                            price[0] = subtort.price;
                            zakaz[0] = ("Большой");
                        }
                        break;

                    case ConsoleKey.Escape:
                        stop++;
                        break;
                }

            }
        }

        private void Forma()
        {
            int stop = 0;
            int pos = 1;
            while (stop != 1)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выберите форму тортика:");
                Console.WriteLine("  Круглый +0р");
                Console.WriteLine("  Квадратный +0р");
                Console.WriteLine("  Треугольный +25р");
                Console.WriteLine("  Гиперболоид +850р");
                Console.WriteLine("  Лента мёбиуса +900р");
                tort.price = price[0] + price[1] + price[2] + price[3] + price[4] + price[5] + price[6];
                Console.WriteLine($"Цена вашего торта: {tort.price}р");
                Console.SetCursorPosition(0, pos);
                Console.Write("■");
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(0, pos++);
                        if (pos == 6)
                        {
                            pos = 5;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(0, pos--);
                        if (pos == 0)
                        {
                            pos = 1;
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (pos == 1)
                        {
                            subtort.price = 0;
                            price[1] = subtort.price;
                            zakaz[1] = ("Круглый");
                        }
                        if (pos == 2)
                        {
                            subtort.price = 0;
                            price[1] = subtort.price;
                            zakaz[1] = ("Квадратный");
                        }
                        if (pos == 3)
                        {
                            subtort.price = 25;
                            price[1] = subtort.price;
                            zakaz[1] = ("Трейгольный");
                        }
                        if (pos == 4)
                        {
                            subtort.price = 850;
                            price[1] = subtort.price;
                            zakaz[1] = ("Гиперболоид");
                        }
                        if (pos == 5)
                        {
                            subtort.price = 900;
                            price[1] = subtort.price;
                            zakaz[1] = ("Лента мёбиуса");
                        }
                        break;
                    case ConsoleKey.Escape:
                        stop++;
                        break;
                }
            }
        }

        private void Vkus()
        {
            int stop = 0;
            int pos = 1;
            while (stop != 1)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выберите начинку тортика:");
                Console.WriteLine("  Без начинки +0р");
                Console.WriteLine("  Шоколад +50р");
                Console.WriteLine("  Горький шоколад +75р");
                Console.WriteLine("  Белый шоколад +75р");
                Console.WriteLine("  Медовик +100р");
                Console.WriteLine("  Наполеон +100р");
                tort.price = price[0] + price[1] + price[2] + price[3] + price[4] + price[5] + price[6];
                Console.WriteLine($"Цена вашего торта: {tort.price}р");
                Console.SetCursorPosition(0, pos);
                Console.Write("■");
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(0, pos++);
                        if (pos == 7)
                        {
                            pos = 6;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(0, pos--);
                        if (pos == 0)
                        {
                            pos = 1;
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (pos == 1)
                        {
                            subtort.price = 0;
                            price[2] = subtort.price;
                            zakaz[2] = ("без начинки");
                        }
                        if (pos == 2)
                        {
                            subtort.price = 50;
                            price[2] = subtort.price;
                            zakaz[2] = ("Шоколад");
                        }
                        if (pos == 3)
                        {
                            subtort.price = 75;
                            price[2] = subtort.price;
                            zakaz[2] = ("Горький шоколад");
                        }
                        if (pos == 4)
                        {
                            subtort.price = 75;
                            price[2] = subtort.price;
                            zakaz[2] = ("Белый шоколад");
                            if (pos == 5)
                            {
                                subtort.price = 100;
                                price[2] = subtort.price;
                                zakaz[2] = ("Медовик");
                            }
                            if (pos == 6)
                            {
                                subtort.price = 100;
                                price[2] = subtort.price;
                                zakaz[2] = ("Наполеон");
                            }

                        }
                        break;
                    case ConsoleKey.Escape:
                        stop++;
                        break;
                }
            }
        }

        private void Korji()
        {
            int stop = 0;
            int pos = 1;
            while (stop != 1)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выберите кол-во коржей тортика:");
                Console.WriteLine("  2 +100р");
                Console.WriteLine("  3 +150р");
                Console.WriteLine("  3 тонких +125р");
                Console.WriteLine("  4 +200р");
                Console.WriteLine("  4 тонких +175р");
                Console.WriteLine("  5 тонких +200р");
                tort.price = price[0] + price[1] + price[2] + price[3] + price[4] + price[5] + price[6];
                Console.WriteLine($"Цена вашего торта: {tort.price}р");
                Console.SetCursorPosition(0, pos);
                Console.Write("■");
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(0, pos++);
                        if (pos == 7)
                        {
                            pos = 6;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(0, pos--);
                        if (pos == 0)
                        {
                            pos = 1;
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (pos == 1)
                        {
                            subtort.price = 100;
                            price[3] = subtort.price;
                            zakaz[3] = ("2 коржа");
                        }
                        if (pos == 2)
                        {
                            subtort.price = 150;
                            zakaz[3] = ("3 коржа");
                            price[3] = subtort.price;
                        }
                        if (pos == 3)
                        {
                            subtort.price = 125;
                            price[3] = subtort.price;
                            zakaz[3] = ("3 тонких коржа");
                        }
                        if (pos == 4)
                        {
                            subtort.price = 200;
                            price[3] = subtort.price;
                            zakaz[3] = ("4 коржа");
                        }
                        if (pos == 5)
                        {
                            subtort.price = 175;
                            price[3] = subtort.price;
                            zakaz[3] = ("4 тонких коржа");
                        }
                        if (pos == 6)
                        {
                            subtort.price = 200;
                            price[3] = subtort.price;
                            zakaz[3] = ("5 тонких коржей");
                        }
                        break;
                    case ConsoleKey.Escape:
                        stop++;
                        break;
                }
            }
        }

        private void Glazur()
        {
            int stop = 0;
            int pos = 1;
            while (stop != 1)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выберите глазурь тортика:");
                Console.WriteLine("  шоколад +25р");
                Console.WriteLine("  горький шоколад +50р");
                Console.WriteLine("  белый шоколад +50р");
                tort.price = price[0] + price[1] + price[2] + price[3] + price[4] + price[5] + price[6];
                Console.WriteLine($"Цена вашего торта: {tort.price}р");
                Console.SetCursorPosition(0, pos);
                Console.Write("■");
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(0, pos++);
                        if (pos == 4)
                        {
                            pos = 3;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(0, pos--);
                        if (pos == 0)
                        {
                            pos = 1;
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (pos == 1)
                        {
                            subtort.price = 25;
                            price[4] = subtort.price;
                            zakaz[4] = ("шоколадная глазурь");
                        }
                        if (pos == 2)
                        {
                            subtort.price = 50;
                            price[4] = subtort.price;
                            zakaz[4] = ("глазурь из горького шоколада");
                        }
                        if (pos == 3)
                        {
                            subtort.price = 50;
                            price[4] = subtort.price;
                            zakaz[4] = ("глазурь из белого шоколада");
                        }
                        break;
                    case ConsoleKey.Escape:
                        stop++;
                        break;
                }
            }
        }

        private void Topping()
        {
            int stop = 0;
            int pos = 1;
            while (stop != 1)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выберите топпинг тортика:");
                Console.WriteLine("  шоколадная крошка +25р");
                Console.WriteLine("  крошка горького шоколада +50р");
                Console.WriteLine("  крем +50р");
                Console.WriteLine("  крошка из белого шоколада +50р");
                Console.WriteLine("  ягоды +100р");
                Console.WriteLine("  бизе +100р");
                Console.WriteLine("  мармеладки +100р");
                tort.price = price[0] + price[1] + price[2] + price[3] + price[4] + price[5] + price[6];
                Console.WriteLine($"Цена вашего торта: {tort.price}р");
                Console.SetCursorPosition(0, pos);
                Console.Write("■");
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(0, pos++);
                        if (pos == 8)
                        {
                            pos = 7;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(0, pos--);
                        if (pos == 0)
                        {
                            pos = 1;
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (pos == 1)
                        {
                            subtort.price = 25;
                            price[5] = subtort.price;
                            zakaz[5] = ("шоколадная крошка");
                        }
                        if (pos == 2)
                        {
                            subtort.price = 50;
                            price[5] = subtort.price;
                            zakaz[5] = ("крошка горького шоколада");
                        }
                        if (pos == 3)
                        {
                            subtort.price = 50;
                            price[5] = subtort.price;
                            zakaz[5] = ("крем");
                        }
                        if (pos == 4)
                        {
                            subtort.price = 50;
                            price[5] = subtort.price;
                            zakaz[5] = ("крошка из белого шоколада");
                        }
                        if (pos == 5)
                        {
                            subtort.price = 100;
                            price[5] = subtort.price;
                            zakaz[5] = ("ягоды");
                        }
                        if (pos == 6)
                        {
                            subtort.price = 100;
                            price[5] = subtort.price;
                            zakaz[5] = ("бизе");
                        }
                        if (pos == 7)
                        {
                            subtort.price = 100;
                            price[5] = subtort.price;
                            zakaz[5] = ("мармеладки");
                        }


                        break;
                    case ConsoleKey.Escape:
                        stop++;
                        break;
                }
            }
        }

        private void Dekor()
        {
            int stop = 0;
            int pos = 1;
            while (stop != 1)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выберите декор  тортика:");
                Console.WriteLine("  фигурка маленькая +300р");
                Console.WriteLine("  фигурка большая  +500р");
                tort.price = price[0] + price[1] + price[2] + price[3] + price[4] + price[5] + price[6];
                Console.WriteLine($"Цена вашего торта: {tort.price}р");
                Console.SetCursorPosition(0, pos);
                Console.Write("■");
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(0, pos++);
                        if (pos == 3)
                        {
                            pos = 2;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(0, pos--);
                        if (pos == 0)
                        {
                            pos = 1;
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (pos == 1)
                        {
                            subtort.price = 300;
                            price[6] = subtort.price;
                            zakaz[6] = ("фигурка маленькая");
                        }
                        if (pos == 2)
                        {
                            subtort.price = 500;
                            price[6] = subtort.price;
                            zakaz[6] = ("фигурка большая");
                        }
                        break;
                    case ConsoleKey.Escape:
                        stop++;
                        break;
                }
            }
        }

        private void EndZakaz()
        {
            int stop = 0;
            Console.Clear();
            Console.WriteLine(File.ReadAllText("C:\\source\\repos\\Pract5\\Torts\\Zakaz.txt"));          
            Console.WriteLine("Escape для выхода, Enter чтобы сделать следующий заказ");
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.Enter)
            {
                return;
            }
            if (key == ConsoleKey.Escape)
            {
                stop++;
            }
        }
    }

}

