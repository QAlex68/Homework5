// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
// Ограничение двух цифр после запятой  Console.Write(num.ToString("F2") + " ");

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double MaxMinDiff(double[] array)
{  
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i]; 
    }
    double diff = max - min;
    return diff;
}

double[] GenerateRandomArray(int elements, double start, double finish)
{
    double[] array = new double[elements];
    for (int i = 0; i < elements; i++)
    {
        array[i] = new Random().NextDouble() * (finish - start) + start;
        
    }
    return array;
}
int elements = GetInput("Введите количество элементов массива: ");
double start = GetInput("Введите начало диапазона элементов массива: ");
double finish = GetInput("Введите конец диапазона элементов массива: ");
double[] array = GenerateRandomArray(elements, start, finish);
Console.WriteLine($"Сгенерирован массив [{String.Join(",", array)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементом в полученном массиве = {MaxMinDiff(array)} !!");

