//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write ("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число С: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int numberMax = 0;
if (numberA > numberB)
{
    numberMax = numberA;
} 
else
{
    numberMax = numberB;
}
    if (numberMax > numberC)
    {
        Console.Write ($"число {numberMax} самое большое");
    }
    else
    {
        Console.Write ($"число {numberC} самое большое");
    }

