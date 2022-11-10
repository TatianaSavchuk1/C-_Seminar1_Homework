//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
//Для решения задания использование цикла for является обязательным условием

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
string strNumber = number.ToString();

int sum = 0;


for (int i = 0; i<=strNumber.Length; i++)
{
    sum = sum + number % 10;
    number = number / 10;
}

Console.WriteLine($"the sum is {sum}");