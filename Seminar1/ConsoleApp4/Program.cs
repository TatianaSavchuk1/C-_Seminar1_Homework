//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write ("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int numberX = 0;
while (numberX <= number)
{
    if (numberX % 2 == 0)
    {
        Console.Write ($"{numberX},");
    }
    numberX = numberX + 1;
} 