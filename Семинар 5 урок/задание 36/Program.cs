// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] Array(int minDlina, int maxDlina, int minNumber, int maxNumber)
{
    int[] array = new int[new Random().Next(minDlina, maxDlina)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minNumber, maxNumber);
    }
    return array;
}

// метод нахождения суммы чисел в четных индексах в массиве
int AnEvenIndexSumNumbersInArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sum += array[i];

    }
    return sum;
}

// Метод нахождения суммы чисел в нечетных индексах массива
int AddIndexSumNumbersInArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = array[i];
    }
    return sum;
}

Console.WriteLine("Выберите действие -> ");
Console.WriteLine("1. Найти сумму чисел в четных индексах в массиве");
Console.WriteLine("2. Найти сумму чисел в нечетных индексах в массиве");
Console.WriteLine("3. Найти сумму всех чисел в массиве");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1)
{
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

    Console.WriteLine($"Сумма чисел в четных индексах равняется {AnEvenIndexSumNumbersInArray(array)}");
}
else if (num == 2)
{
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

    Console.WriteLine($"Сумма чисел в нечетных индексах равняется {AddIndexSumNumbersInArray(array)}");
}
else if (num == 3)
{
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

    Console.WriteLine($"Сумма всех чисел равняется {AnEvenIndexSumNumbersInArray(array) + AddIndexSumNumbersInArray(array)}");
}
else
{
    Console.WriteLine("Вы ввели не 1 и 2, и 3. Попробуйте еще раз");
}
