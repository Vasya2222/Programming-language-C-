// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [ 10, 11, 12, 13, 14 ] -> 5

// метод создания массива
int[] Array(int minDlina, int maxDlina, int minNumber, int maxNumber)
{
    int[] array = new int[new Random().Next(minDlina, maxDlina)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minNumber, maxNumber);
    }
    return array;
}

// метод для нахождения количеств чисел в диапазоне между 10 и 99
int FindNumberBetween10And99(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите минимальное рандомное число -> ");
int minRandomNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Введите максимальное рандомное число -> ");
int MaxRandomNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Введите минимальное рандомное длину массива -> ");
int MinDlinaArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Введите максимальное рандомное длину массива -> ");
int MaxDlinaArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Массив");
int[] array = Array(MinDlinaArray, MaxDlinaArray, minRandomNumber, MaxRandomNumber);
Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine($"Количество чисел находящиещееся между 10 и 99 равно {FindNumberBetween10And99(array)}");