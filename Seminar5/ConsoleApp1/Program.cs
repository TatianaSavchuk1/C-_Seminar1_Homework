//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int CountEvenNumbers (int[]array)
{
  int sum = 0;
    for (int a = 0; a < array.Length; a++)
    {
        if (array[a] % 2 == 0)
        {
            sum = sum + 1;
        } 
    }
    
    return sum;
}

int[]array = new int [10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write (array[i] + " ");
}

CountEvenNumbers(array);
 
Console.WriteLine ($"Количество чётных чисел = {CountEvenNumbers(array)}");



