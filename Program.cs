// Задача 10
int number;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine(), out number);
int a = number % 100;
int b = a / 10;
Console.Write($"{b}");

// Задача 13

int number1;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine(), out number1);
int a1 = number1 % 10;
int b1 = a1 / 100;
if (b1 > 1) 
{
    Console.Write($"{a1}");
}
else
{
    Console.Write("Нет третьего числа");
}

//Задача 15

int day;
Console.Write("Введите номер дня недели: ");
int.TryParse(Console.ReadLine(), out day);
if (day < 6)
{
    Console.Write("Рабочий");
}
else
{
    Console.Write("Выходной");
}