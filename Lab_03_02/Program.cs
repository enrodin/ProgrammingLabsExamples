﻿/*
 ┌────────────────────────────────────────────────────────────────────────────────────────────┐
 │ Практическое занятие №3.                                                                   │
 ├────────────────────────────────────────────────────────────────────────────────────────────┤
 │ Разработка разветвляющегося алгоритма, используя оператор выбора.                          │
 ├────────────────────────────────────────────────────────────────────────────────────────────┤
 │ Пример 2. Определение знака зодиака по дате рождения.                                      │
 ├────────────────────────────────────────────────────────────────────────────────────────────┤
 │ Напишите программу, которая запрашивает у пользователя дату рождения в формате ДД.ММ.ГГГГ, │
 │ а затем выводит его знак зодиака.                                                          │
 └────────────────────────────────────────────────────────────────────────────────────────────┘
 
 ┌───────────────────────────────────────────────┐
 │ Выполнение программы.                         │
 ├──────────────────────────┬────────────────────┤
 │ Входные данные:          │ Выходные данные:   │
 ├──────────────────────────┼────────────────────┤
 │ дата рождения:           │ знак зодиака:      │
 │ birthDate = "21.12.2012" │ zodiac = "стрелец" │
 └──────────────────────────┴────────────────────┘
 */

namespace Lab_03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическое занятие №3. Пример 2.";

            Console.Write("Введите дату рождения: ");
            var birthDate = DateTime.Parse(Console.ReadLine());

            var zodiac = string.Empty;

            switch (birthDate.Month * 100 + birthDate.Day)
            {
                // с 22.12 по 19.01 
                case var value when (value >= 101  && value <= 119) || 
                                    (value >= 1223 && value <= 1231):
                    zodiac = "козерог";
                    break;

                // с 20.01 по 18.02
                case var value when value >= 120 && value <= 218:
                    zodiac = "водолей";
                    break;

                // с 19.02 по 20.03
                case var value when value >= 219 && value <= 320:
                    zodiac = "рыбы";
                    break;

                // с 21.03 по 19.04
                case var value when value >= 321 && value <= 419:
                    zodiac = "овен";
                    break;

                // с 20.04 по 20.05
                case var value when value >= 420 && value <= 520:
                    zodiac = "телец";
                    break;

                // с 21.05 по 20.06
                case var value when value >= 521 && value <= 621:
                    zodiac = "близнецы";
                    break;

                // с 21.06 по 22.07
                case var value when value >= 622 && value <= 722:
                    zodiac = "рак";
                    break;

                // с 23.07 по 22.08
                case var value when value >= 723 && value <= 822:
                    zodiac = "лев";
                    break;

                // с 23.08 по 22.09
                case var value when value >= 823 && value <= 922:
                    zodiac = "дева";
                    break;

                // с 23.09 по 22.10
                case var value when value >= 923 && value <= 1023:
                    zodiac = "весы";
                    break;

                // с 23.10 по 21.11
                case var value when value >= 1024 && value <= 1123:
                    zodiac = "скорпион";
                    break;

                // с 22.11 по 21.12
                case var value when value >= 1124 && value <= 1222:
                    zodiac = "стрелец";
                    break;

                default:
                    zodiac = "не определен";
                    break;
            }

            Console.WriteLine($"Ваш знак зодиака: {zodiac}.");

            Console.ReadLine();
        }
    }
}
