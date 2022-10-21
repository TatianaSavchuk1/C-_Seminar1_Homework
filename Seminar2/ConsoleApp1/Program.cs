//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.Write("введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result;

result = number / 10;
result = result % 10;

Console.Write($"вторая цифра: {result}");
