// Задача *. Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сортировку
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
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

int[] array = GetArray(size, minValue, maxValue);
Console.WriteLine(String.Join(" ", array));

void sort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
}
sort(array);
Console.WriteLine(String.Join(" ", array));