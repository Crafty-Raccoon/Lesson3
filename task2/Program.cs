//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B(2, 1, -7), -> 15.84

//A(7, -5, 0); B(1, -1, 9)-> 11.53

Console.WriteLine("Введите координаты первой точки через пробел");
int[] point1 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

Console.WriteLine("Введите координаты второй точки через пробел");
int[] point2 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

int x1 = point1[0];
int y1 = point1[1];
int z1 = point1[2];

int x2 = point2[0];
int y2 = point2[1];
int z2 = point2[2];

double Result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
Console.WriteLine("Расстояние между точками "+Result.ToString("0.00"));