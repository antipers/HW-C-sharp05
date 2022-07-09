// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[20];
void fillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        System.Console.Write($"{array[i]}, ");

    }
    System.Console.WriteLine("\b\b \b");
}

void findMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        else if (min > array[i]) min = array[i];

    }
    System.Console.WriteLine($"min значение={min} и max значение={max}");
    System.Console.WriteLine($"Разница ={max - min}");
}

fillArray(array);
findMaxMin(array);