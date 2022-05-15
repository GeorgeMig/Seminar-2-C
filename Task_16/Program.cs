Console.WriteLine("Настоящая программа способна определить, является ли одно число квадратом другого.");
Console.Write("Введите любое положительное число =>" + " ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите ёщё одно число =>" + " ");
int num2 = int.Parse(Console.ReadLine());
int minnum = 0;
int maxnum = 0;
if (num1 < num2)
{
    minnum = num1;
    maxnum = num2;
}
else 
{
   minnum = num2;
   maxnum = num1;
}

if (minnum * minnum == maxnum)
{
    Console.WriteLine("Да, является");
}
else
{
    Console.WriteLine("Нет, не является");
}