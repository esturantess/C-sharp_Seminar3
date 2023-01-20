// Задача: Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек (X, Y) в этой четверти.

System.Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] array = { "x > 0, y > 0", "x > 0, y < 0", "x < 0, y <0", "x < 0, y > 0", "Введено некорректное число." };
switch (num)

{
    case 1:
        System.Console.WriteLine(array[0]);
        break;
    case 2:
        System.Console.WriteLine(array[3]);
        break;
    case 3:
        System.Console.WriteLine(array[2]);
        break;
    case 4:
        System.Console.WriteLine(array[1]);
        break;
    default:
        System.Console.WriteLine(array[4]);
        break;
}
