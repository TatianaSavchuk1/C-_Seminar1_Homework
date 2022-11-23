//Напишите программу, которая будет принимать от пользователя позицию (M, N) двумерного массива и возвращать значение элемента, стоящего в этой позиции. 
//Если такой позиции в массиве нет, то сообщить об этом пользователю. Сгенерировать массив случайным образом. Размерность массива определить самостоятельно. 
//Использование методов для заполнения массива обязательно. Остальное можно реализовать в главной программе.

void FillArray (int[,]array)
{

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1,11);
        Console.Write(array [i,j] + " ");
    }
    Console.WriteLine();
}
}


int m = 4;
int n = 5;
int [,] array = new int [m,n];



FillArray(array);

Console.WriteLine ("Введите позицию M: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите позицию N: ");
int b = Convert.ToInt32(Console.ReadLine());

if ( a > m || b > n)
{
    Console.WriteLine("В массиве отсутствует элемент в такой позиции");
  
}

else
{
   Console.WriteLine($"Значение элемента в этой позиции: {array[a,b]}");
}



              