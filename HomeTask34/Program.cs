// Задача #34. Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве
Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное трехзначное число диапазона массива: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное трехзначное число диапазона массива: ");
int maxValue = int.Parse(Console.ReadLine()!);
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(Math.Abs(minValue), Math.Abs(maxValue) + 1);
    }
    return res;
}

int[] array = GetArray(size, minValue, maxValue);
Console.WriteLine(String.Join(" ", array));

int evenNumber(int count)
{
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int result = evenNumber(0);
Console.WriteLine($"Количество чётных чисел в массиве равно {result}");