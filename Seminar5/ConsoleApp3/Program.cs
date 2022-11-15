//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[]array = new double [10];
for (int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(-100, 101);
    Console.Write(array[i] + " ");
}
double min = 0;
double max = 0;
double difference = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }


    if (array[i] > max)
    {
        max = array[i];
    }
}

if (min >= 0)
{
    difference = max - min;
}

else
{
difference = max + min;
}

Console.WriteLine ($"Разность между макс и мин элементами = {difference}");

