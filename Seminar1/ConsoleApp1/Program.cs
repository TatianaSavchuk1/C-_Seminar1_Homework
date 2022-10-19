//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write ("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine($"число {numberA} больше");
}
else
{
    Console.WriteLine($"число {numberB} больше");
}