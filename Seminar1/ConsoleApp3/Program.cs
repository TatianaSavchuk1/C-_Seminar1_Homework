//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
Console.Write ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("число чётное");
}
else
{
    Console.WriteLine("число нечётное");
}
