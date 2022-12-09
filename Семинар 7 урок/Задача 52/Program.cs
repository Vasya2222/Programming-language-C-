// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк -> ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбец -> ");
int x = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[y, x];
FillArray2D(numbers);
PrintArray2D(numbers);


// Заполнение массива рандомными числами
void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 1000);
        }
    }
}

//  Функция вывода массива в терминал
void PrintArray2D(int[,] array)
{
    // int[,] arr = new int[array.GetLength(0), array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine(Math.Round(Convert.ToDouble(sum) / array.GetLength(1), 3));
    }
    Console.WriteLine();
}