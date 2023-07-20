// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int EvenNumbers(int[] array)
{  
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int[] GenerateRandomArray(int elements, int start, int finish)
{
    int[] array = new int[elements];
    for (int i = 0; i < elements; i++)
    {
        array[i] = new Random().Next(start, finish + 1);
    }
    return array;
}
int elements = GetInput("Введите количество элементов массива: ");
int start = GetInput("Введите начало диапазона элементов массива (трехзначное целое число): ");
int finish = GetInput("Введите конец диапазона элементов массива (трехзначное целое число): ");
int[] array = GenerateRandomArray(elements, start, finish);
Console.WriteLine($"Сгенерирован массив [{String.Join(",", array)}]");
Console.WriteLine($"Количество четных чисел в полученном массиве = {EvenNumbers(array)} !!");
