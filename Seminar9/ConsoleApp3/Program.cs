﻿//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunc(int m, int n)
		{
			if(m == 0)
			{
				return n + 1;
			}
			if(m > 0 && n == 0)
			{
				return AkkermanFunc(m - 1, 1);
			}
			return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
		}

Console.WriteLine("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = AkkermanFunc(m,n);
Console.WriteLine(result);
