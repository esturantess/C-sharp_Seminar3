// Задача: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// System.Console.WriteLine("Введите координату Х первой точки:");
// int firstPointX = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите координату Y первой точки:");
// int firstPointY = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите координату Х второй точки:");
// int secondPointX = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите координату Y второй точки:");
// int secondPointY = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Расстояние между точкой с координатами ({firstPointX},{firstPointY}) и точкой с координатами ({secondPointX},{secondPointY}) в 2D пространстве: {Math.Sqrt(Math.Pow((secondPointX - firstPointX), 2) + (Math.Pow((secondPointY - firstPointY), 2)))}");

// Решение через массив:

double[] coordsA = new double[2];
double[] coordsB = new double[2];

System.Console.WriteLine("Введите координату Х первой точки:");
coordsA[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Y первой точки:");
coordsA[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Х второй точки:");
coordsB[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Y второй точки:");
coordsB[1] = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((coordsB[0] - coordsA[0]), 2) + Math.Pow((coordsB[1] - coordsA[1]), 2));

System.Console.WriteLine($"Расстояние между точками A({coordsA[0]},{coordsA[1]}) и B({coordsB[0]},{coordsB[1]}) в 2D пространстве: {distance}");