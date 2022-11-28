// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int [,] array = new int[4,5];
int [] sum = new int [5];
for (int i = 0; i < 5; i++)
{
    sum[i] = 0;
   
}
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < 4; i++)
{
    for ( int j = 0; j < 5; j++)
    {
        array[i,j] = new Random().Next(1,11);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();



for (int i = 0; i < 4; i++)
{
    for ( int j = 0; j < 5; j++)
    {
        sum[i] = sum[i] + array[i,j];
        
    }
    
    Console.Write(sum[i] + "  ");       
}
            
Console.WriteLine();


int min = 0;
int minRow = 0;

for (int i = 0; i < 4; i++)
{
     min = sum[i];

    if (sum[i] < min)
    {
       min = sum[i];
       minRow = i+1;

    }
    
}
    Console.Write($"minimal sum row  = {minRow}");

     