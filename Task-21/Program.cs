﻿// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Round(Distans3D(x1,y1,z1,x2,y2,z2),2));

double Distans3D (int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{ 
    double result = Math.Sqrt(Math.Pow((xc1-xc2),2) + Math.Pow((yc1-yc2),2) + Math.Pow((zc1-zc2),2));
    return result;
}