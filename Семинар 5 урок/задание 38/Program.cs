// Задача 38: Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] Array(int size)
{
    double[] array = new Double[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        Console.Write("Введите вещественное число -> ");
        array[i] = double.Parse(Console.ReadLine());
    }
    return array;
}

double FindTheDifferenceBetweenMaxAndMinNumber(double[] array){
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < array.Length; i++){
        if (min > array[i]){
            min = array[i];
        }
        if (max < array[i]){
            max = array[i];
        }
    }
    return max - min;
}

Console.WriteLine("Введите минимальное рандомное число -> ");
int SizeArray = Convert.ToInt32(Console.ReadLine());

double[] array = Array(SizeArray);

Console.WriteLine($"Разница между максимальным элементом и минимальным элементом равняется {FindTheDifferenceBetweenMaxAndMinNumber(array)}");