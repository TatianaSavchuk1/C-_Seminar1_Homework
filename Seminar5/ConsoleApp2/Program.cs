//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int FindUnevenSum (int[]array)
{
    int sum = 0;
    for (int a = 1; a < array.Length; a = a+2)
    {
        sum = sum + array[a];
        
    }

    return sum;
}

int[]array = new int [20];
for (int i = 0; i< array.Length; i++)
{
    array[i] = new Random().Next(-100, 101);
    Console.Write (array[i] + " ");
}

FindUnevenSum(array);
Console.WriteLine($"сумма элементов = {FindUnevenSum(array)}");