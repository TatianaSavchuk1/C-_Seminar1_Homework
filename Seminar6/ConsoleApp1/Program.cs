 /*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Склько чисел Вы хотите ввести? : ");
int M = Convert.ToInt32(Console.ReadLine());

int[]array = new int[M];
int sum = 0;

for(int i = 0; i<M; i++)
{
    
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    array[i] = number;
    
    if (array[i] > 0)
    {
        sum++;
    }
}

Console.WriteLine($"Выввели {sum} положительных чисел.");