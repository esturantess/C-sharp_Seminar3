// Задача: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

System.Console.WriteLine("Введите координату Х первой точки:");
int firstPointX = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Y первой точки:");
int firstPointY = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Х второй точки:");
int secondPointX = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Y второй точки:");
int secondPointY = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Расстояние между точкой с координатами ({firstPointX},{firstPointY}) и точкой с координатами ({secondPointX},{secondPointY}) в 2D пространстве: {Math.Sqrt(Math.Pow((secondPointX - firstPointX), 2) + (Math.Pow((secondPointY - firstPointY), 2)))}");