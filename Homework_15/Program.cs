Console.WriteLine ("Эта программа позволяет определить совпадает ли введенное Вами число с порядком выходного дня на неделе.");
Console.Write ("Введите число от 1 до 7 => ");
int num = int.Parse(Console.ReadLine());
Console.Write( num == 7 || num == 6 ? "да " : "нет");
