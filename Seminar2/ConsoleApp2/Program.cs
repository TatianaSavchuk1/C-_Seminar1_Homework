//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result;

while (number >= 1000)
{
    number = number / 10;
   
}

result = number % 10;

if (number < 100)
{
    Console.Write("Третьей цифры нет");
}

else
{
    Console.Write($"Третья цифра {result}");
}