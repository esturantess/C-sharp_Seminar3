// Задача: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int[] coords = new int[2]; // создали массив и выделили память под два элемента в массиве coords
System.Console.Write("Введите Х: ");
coords[0] = Convert.ToInt32(Console.ReadLine()); // получили переменную X и записали ее в массив под нулевым индексом

System.Console.Write("Введите Y: ");
coords[1] = Convert.ToInt32(Console.ReadLine()); // получили переменную Y и записали ее в массив под индексом один

if (coords[0] > 0 && coords[1] > 0) // если значение массива с индексом 0 больше нуля и значение массива с индексом 1 больше нуля
{
    System.Console.WriteLine("Номер четверти - 1");
}
else if (coords[0] < 0 && coords[1] > 0)
{
    System.Console.WriteLine("Номер четверти - 2");
}
else if (coords[0] < 0 && coords[1] < 0)
{
    System.Console.WriteLine("Номер четверти - 3");
}
else if (coords[0] > 0 && coords[1] < 0)
{
    System.Console.WriteLine("Номер четверти - 4");
}
else
{
    System.Console.WriteLine("Точка находится в центре системы координат");
}