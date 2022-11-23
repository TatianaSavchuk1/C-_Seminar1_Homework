﻿//Запросите от пользователя размерности двумерного массива. Напишите метод для заполнения массива случайными числами. 
//Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво). Округлите значения, генерируемые Random до двух знаков после запятой.

void FillArray (double[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().NextDouble() + new Random().Next(1, 11);
    
    
        }
    }
       
}

void ShowArray (double[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i,j], 2) + "  ");
        }

        Console.WriteLine();
        Console.WriteLine();

    }
    
}

Console.WriteLine("Enter number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,]array = new double [m,n];


FillArray (array);
ShowArray(array);