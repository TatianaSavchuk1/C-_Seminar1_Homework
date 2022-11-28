/*адайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int [,]array = new int [2,2];
int [,]array2 = new int [2,2];
int [,]result = new int [2,2];

for (int i = 0; i < array.GetLength(0); i++)
{
    for ( int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1,11);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < array2.GetLength(0); i++)
{
    for ( int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i,j] = new Random().Next(1,11);
        Console.Write(array2[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
         result[i, j] = 0;
 
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    result[i, j] = array[i, k] * array2[k, j];
                    
                }
            
        Console.Write(result[i,j] + " ");
    }
    Console.WriteLine();
}

