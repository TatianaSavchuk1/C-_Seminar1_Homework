//Запросите от пользователя размерности двумерного массива. Напишите метод для заполнения массива случайными числами. 
//Напишите метод для поиска ср. арифметического значения каждого столбца.

void FillArray (int[,]array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1,11);
        Console.Write(array [i,j] + "   ");
    }
    Console.WriteLine();
}
Console.WriteLine();
}

void CountAverage (int[,]array)
{
   double[]average = new double [array.GetLength(1)];

   for (int i = 0; i < array.GetLength(1); i++)
    {
        average[i] = 0;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            average[i] = average[i] + array[j,i];  
        }   
        average[i] = average[i]/array.GetLength(0);
        Console.Write(Math.Round(average[i],1) + "  ");
    }  
} 

Console.WriteLine ("Введите позицию M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите позицию N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] array = new int [m,n];

FillArray (array);
CountAverage (array);