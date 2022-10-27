
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double CountDistance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    
double distance = Math.Sqrt(Math.Pow (x2-x1, 3) + Math.Pow(y2-y1, 3) + Math.Pow(z2-z1, 3));

return distance;
}




Console.WriteLine ("enter x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("enter y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("enter z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("enter x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("enter y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("enter z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = CountDistance(x1, y1, z1, x2, y2, z2);



Console.WriteLine ($"the distance is: {distance}");