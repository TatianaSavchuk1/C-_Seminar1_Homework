// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Заполнение массива производит пользователь.

int[] array = new int [8];
for (int i = 0; i<=7; i++)
{
    Console.WriteLine("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    array[i] = number;

}

for (int i = 0; i<=7; i++)
{
Console.Write(array[i] + ", ");
}