//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

void PrintCubeToConsole (int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine (i*i*i);
    }

}

Console.WriteLine ("enter number n: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintCubeToConsole(n);