// создаем переменную со случайным числом в диапозоне от 10 до 100.

int num = new Random().Next(10, 100);
Console.WriteLine(num);

//int firstDigit = num / 10;
//int secondDigit = num % 10;


// стандартный алгоритм:
//if (firstDigit > secondDigit) Console.WriteLine($"Max = {firstDigit}");
//else Console.WriteLine ($"Max = {secondDigit}");

// Ниже представлен тернарный оператор (упрощенная запись алгоритма выше)

//    ВИД ДЕЙСТВИЯ        УСЛОВИЕ (ЕСЛИ)     ТО    ДЕЛАЕМ ЭТО      ИНАЧЕ   ДЕЛАЕМ ЭТО  
//Console.WriteLine(firstDigit > secondDigit ? $"Max = {firstDigit}" : $"Max = {secondDigit}");

//Можно записать тернарный оператор не через консоль, а через переменную. Пример:
//var res = firstDigit > secondDigit ? $"Max = {firstDigit}" : $"Max = {secondDigit};
//Console.WriteLine(res);
// var - это переменная любого типа. Не всегда работает.


// Пример реализации алгоритма через функцию (метод):

int maxNumber = GetMaxDigit (num);
Console.WriteLine (maxNumber);


int GetMaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
