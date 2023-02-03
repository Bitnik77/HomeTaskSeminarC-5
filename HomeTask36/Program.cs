// Задача №36. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях
Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное число диапазона массива: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное число диапазона массива: ");
int maxValue = int.Parse(Console.ReadLine()!);
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] array = GetArray(size, minValue, maxValue);
Console.WriteLine(String.Join(" ", array));

int oddPositions(int sum)
{
    for (int i = 1; i < size; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int result = oddPositions(0);
Console.WriteLine($"Сумма элементов на нечётных позициях массива равна {result}");