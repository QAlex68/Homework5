// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Задача решена для чисел с нечетными индексами как в условии!!

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfOddIndex(int[] array)
{  
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
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
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях в полученном массиве = {SumOfOddIndex(array)} !!");
