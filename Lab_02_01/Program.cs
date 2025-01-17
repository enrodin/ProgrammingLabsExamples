﻿/*
 ┌────────────────────────────────────────────────────────────────────────────────┐
 │ Практическое занятие №2.                                                       │
 ├────────────────────────────────────────────────────────────────────────────────┤
 │ Разработка разветвляющегося алгоритма, используя оператор условия.             │
 ├────────────────────────────────────────────────────────────────────────────────┤
 │ Пример 1. Определение положения точки на координатной плоскости.               │
 ├────────────────────────────────────────────────────────────────────────────────┤
 │ Напишите программу, которая запрашивает у пользователя координаты точки (x; y) │
 │ и определяет положение точки на координатной плоскости.                        │
 └────────────────────────────────────────────────────────────────────────────────┘
 
 ┌────────────────────────────────────────┐
 │ Выполнение программы.                  │
 ├───────────────────┬────────────────────┤
 │ Входные данные:   │ Выходные данные:   │
 ├───────────────────┼────────────────────┤
 │ координаты точки: │ положение:         │
 │ x = 12,8          │ position = "первая │
 │ y = 5,1           │ четверть"          │
 └───────────────────┴────────────────────┘
 */

namespace Lab_02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическое занятие №2. Пример 1.";

            Console.Write("Введите координату x: ");
            var x = double.Parse(Console.ReadLine());

            Console.Write("Введите координату y: ");
            var y = double.Parse(Console.ReadLine());

            var position = string.Empty;

            if (x > 0 && y > 0)
            {
                position = "первая четверть";
            }
            else if (x < 0 && y > 0)
            {
                position = "вторая четверть";
            }
            else if (x > 0 && y < 0)
            {
                position = "третья четверть";
            }
            else if (x < 0 && y < 0)
            {
                position = "четвертая четверть";
            }
            else if (x == 0 && y != 0)
            {
                position = "ось Y";
            }
            else if (x != 0 && y == 0)
            {
                position = "ось X";
            }
            else
            {
                position = "начало координат";
            }

            Console.Write($"Положение точки с координатами ({x}; {y}): {position}.");

            Console.ReadLine();
        }
    }
}
