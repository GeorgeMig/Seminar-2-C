// ПРОГРАММА, КОТОРАЯ ВЫВОДИТ СЛУЧАЙНОЕ  ЧИСЛО И ОПРЕДЕЛЯЕТ ТРЕТЬЮ ЦИФРУ ЭТОГО ЧИСЛА

// 
// Решение при помощи метода (функции). (НЕ УНЕВИРСАЛЬНЫЙ. НУЖНО ДОДУМАТЬ)

int number = new Random().Next(10, 1000);
if (number > 99)
    {
        int thirdDigit = number % 10;
        Console.Write($"{number} => {thirdDigit}");

    }
    else
    {
        int thirdDigit = (number * 10) % 10;
        Console.Write($"{number} => третьей цифры нет");
    }


