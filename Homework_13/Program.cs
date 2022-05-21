// ПРОГРАММА, КОТОРАЯ ОПРЕДЕЛЯЕТ ТРЕТЬЮ ЦИФРУ ЗАДАННОГО ЧИСЛА (ЛЮБОЕ).

Console.Write("Введите любое положительное число от 0 и выше => ");
int number = int.Parse(Console.ReadLine());

int n = number;

while (n >= 1000)
{
    
   n = n / 10; 
}

if (n > 99 && n < 1000)
    {
        int thirdDigit = n % 10;
        Console.Write($"{number} => {thirdDigit}");

    }
    else if (n < 100)
    {
        Console.Write($"{number} => третьей цифры нет");
    }
