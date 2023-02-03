// Задача №38. Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива

Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное число диапазона массива: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное число диапазона массива: ");
int maxValue = int.Parse(Console.ReadLine()!);
double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    }
    return res;
}

double[] array = GetArray(size, minValue, maxValue);
Console.WriteLine(String.Join(" ", array));

//Способ №1
double diffMax(double max)
{
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] > max)
       {
        max = array[i];
       }
       i++;
    }
    return max;
}

double diffMin(double min)
{
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] < min)
       {
            min = array[i];
       }
       i++;
    }
    return min;
}
double result = diffMax(minValue);
double result1 = diffMin(maxValue);
double diff = result - result1;

Console.WriteLine($"Разница между максимальным {result} и минимальным {result1} элементами массива равна {diff}");

//Способ №2
//double max = array.Max();
//double min = array.Min();
//double diff = array.Max() - array.Min();
//Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементами массива равна {diff}");