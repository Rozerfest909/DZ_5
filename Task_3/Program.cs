// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int ReadInt(string msg)
{
    System.Console.Write($"{msg} > ");
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(int length, int minRnd, int maxRnd)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minRnd, maxRnd + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int Max(int[] array)
{
    int n = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (n < array[i])
        {
            n = array[i];
        }
    }
    return n;
}

int Min(int[] array)
{
    int n = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (n > array[i])
        {
            n = array[i];
        }
    }
    return n;
}

int len = ReadInt("Введите длину массива");
int minRnd = ReadInt("Введите границу минимума случайной ведичины");
int maxRnd = ReadInt("Введите границу максимума случайной ведичины");
int[] array = CreateArray(len, minRnd, maxRnd);
PrintArray(array);
System.Console.WriteLine($"Разница между максимальным ({Max(array)}) и минимальным ({Min(array)}) элементом массива равна {Max(array) - Min(array)}");