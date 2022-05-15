// ПРОГРАММА, КОТОРАЯ ВЫВОДИТ СЛУЧАЙНОЕ ТРЁХЗНАЧНОЕ ЧИСЛО И ОПРЕДЕЛЯЕТ ВТОРУЮ ЦИФРУ ЭТОГО ЧИСЛА.

// Альтернативный алгоритм
//int num = new Random().Next(99, 1000);
//int firstDigit = num / 10;
//int secondDigit = firstDigit % 10;
//Console.Write ($"{num} => {secondDigit}");


// Решение при помощи метода (функции).

int num = new Random().Next(99, 1000);
int res = FindSecondDig (num);
Console.Write ($"{num} => {res}");


int FindSecondDig(int number)
{
    int firstDigit = number / 10;
    int secondDigit = firstDigit % 10;
    return secondDigit;
}