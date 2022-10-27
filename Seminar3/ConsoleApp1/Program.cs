
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


int Palindrome (int number)
{
    int n = 0;
    while (number > 0)
    {
        n = 10 * n + number % 10;
        number = number/10;
    }
    return n;
}

Console.WriteLine ("введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Palindrome (number);


if (number == Palindrome (number))
{
    Console.WriteLine ("число - палиндром");
}

else
{
    Console.WriteLine ("число - не палиндром");
}