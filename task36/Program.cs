// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0



void fillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        System.Console.Write($"{array[i]}, ");

    }
    System.Console.WriteLine("\b\b \b");
}
int[] array = new int[10];
fillArray(array);
System.Console.WriteLine();
int result = 0;
for (int i = 1; i < array.Length; i+=2)
{
    
    result=result+ array[i];
}
System.Console.WriteLine($"{result}");

