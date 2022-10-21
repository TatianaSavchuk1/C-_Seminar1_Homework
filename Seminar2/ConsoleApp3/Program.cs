//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine ("введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

while ( number > 7 || number < 1)
{
    Console.WriteLine("нужно ввести число от 1 до 7");
    break;
}
if (number == 6 || number == 7)
{
    Console.WriteLine("это выходной!");
}

if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
{
    Console.WriteLine("это не выходной");
}

