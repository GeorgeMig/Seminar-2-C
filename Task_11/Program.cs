// ПРОГРМАА, КОТОРАЯ ВЫВОДИТ СЛУЧАЙНОЕ ТРЁХЗНАЧНОЕ ЧИСЛО И УДАЛЯЕТ ВТОРУЮ ЦИФРУ ЭТОГО ЧИСЛА.

int num = new Random().Next(99, 1000);
Console.WriteLine(num);
int firstDigit = num / 100;
int thirdDigit = num % 10;
Console.Write (firstDigit);
Console.Write (thirdDigit);