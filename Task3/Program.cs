// Задача: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

int size = Convert.ToInt32(Console.ReadLine());
if (size > 0)
{
    int[] array = new int[size];
    int index = 0;
    while (index < size)
    {
        array[index] = index + 1;
        System.Console.Write($"{Math.Pow(array[index], 2)} ");
        index++;
    }
}
else
{
    System.Console.WriteLine($"Введенное число ({size}) меньше 1.");
}