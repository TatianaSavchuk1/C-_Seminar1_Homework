//Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
//Для решения задания использование цикла for является обязательным условием. Не использовать встроенный метод возведения в степень.

Console.WriteLine("Веедите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Веедите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int powNumber = 1;

for (int i = 1; i <= numberB; i++)
{
    powNumber = powNumber*numberA;
}

Console.WriteLine($"the answer is {powNumber}");