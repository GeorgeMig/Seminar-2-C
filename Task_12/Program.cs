﻿// ПРОГРАММА, КОТОРАЯ ПРИНИМАЕТ НА ВХОД ДВА ЧИСЛА И ВЫВОДИТ, ЯВЛЯЕТСЯ ЛИ ПЕРВОЕ ЧИСЛО КРАТНО ВТОРОМУ. ЕСЛИ ЧИСЛО 2 НЕ КРАТНО ЧИСЛУ 1, ТО ПРОГРАММА ВЫВОДИТ ОСТАТОК ОТ ДЕЛЕНИЯ.

Console.WriteLine("Данная программа определяет кратно ли первое число второму числу.");
Console.Write("Введите любое положительное число =>" + " ");
double num1 = int.Parse(Console.ReadLine());
Console.Write("Еще одно =>" + " ");
double num2 = int.Parse(Console.ReadLine());
double res = ((num1 / num2) * 10) % 10;
Console.WriteLine(res > 0 ? $"Число {num1} некратно числу {num2}, остаток {res}" : $"Число {num1} кратно числу {num2}");
