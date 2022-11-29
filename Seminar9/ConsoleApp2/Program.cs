//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 301"

int MtoNnumbers (int m, int n)
{
   Console.Write (m + " ");

   if(m == n)
   {
    return n;
   }
   return MtoNnumbers (m + 1, n);

}

Console.WriteLine("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < m)

{
    int temp = n;
    n = m;
    m = temp;
}


MtoNnumbers(m,n);
