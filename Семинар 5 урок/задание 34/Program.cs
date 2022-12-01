// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// // [345, 897, 568, 234] -> 2

// Инициализируем метод с рандомным массивом
int[] RandomArray(int minDlina, int maxDlina, int minNumber, int maxNumber)
{
    int[] array = new int[new Random().Next(minDlina, maxDlina)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minNumber, maxNumber);
    }
    return array;
}

// Инициализируем метод в которой пользователь ввел массив в ручную
int[] PersonArray(int dlinaArray)
{
    int[] array = new int[dlinaArray];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

// метод нахождения четных чисел в массиве
int AnEvenNumberInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

// Метод нахождения нечетных чисел
int AddNumberInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            count++;
        }
    }
    return count;
}

// заголовок программы
Console.WriteLine("Программа для вычисления количества чисел в массиве на четность и на нечетность или все вместе");

bool repeatWhile = true;

// пока пользователь не ввел нет, делаем
while (repeatWhile == true)
{
    // Показываем, что может делать наша программа
    Console.WriteLine("Выберите действие -> ");
    Console.WriteLine("1. Найти количество четных чисел в массиве");
    Console.WriteLine("2. Найти количество нечетных  чисел в массиве");
    Console.WriteLine("3. Найти количества четных и нечетных чисел");
    int num = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    // Спрашиваем у пользователя, как он хочет использовать нашу программу
    Console.WriteLine("Как вы хотите заполнить массив. Если лично введите 'да', иначе 'нет'");
    string? answer = Console.ReadLine();
    if (num == 1)
    {
        Console.WriteLine("Вы выбрали 'Найти количество четных чисел в массиве'");
        // Если пользователь хочет сам ввести массив
        if (answer == "да")
        {
            bool repeatWhile1 = true;
            // пока пользователь не ввел нет, делаем
            while (repeatWhile1 == true)
            {

                Console.WriteLine("Введите длину массива -> ");
                int dlinaArray = Convert.ToInt32(Console.ReadLine());
                int[] array = PersonArray(dlinaArray);

                Console.WriteLine();

                Console.WriteLine("Массив");
                Console.WriteLine($"[{string.Join(", ", array)}]");

                Console.WriteLine();
                // Выводим что получисль в методе для нахождения количества четных чисел
                Console.WriteLine($"Количество четных чисел в массиве равно {AnEvenNumberInArray(array)}");

                Console.WriteLine();
                // Спрашиваем у пользователя, хочет ли он еще раз набрать массив
                Console.WriteLine("Вы хотите еще раз набрать массив? Если да, введите 'да', иначе 'нет'");
                string? answer2 = Console.ReadLine();
                if (answer2.ToLower() == "да")
                {
                    repeatWhile1 = true;
                }
                else
                {
                    repeatWhile1 = false;
                    break;
                }
            }
        }
        // Пользователь хочет чтобы массив был рандомным
        else
        {
            bool repeatWhile2 = true;
            // пока пользователь не ввел нет, делаем
            while (repeatWhile2 == true)
            {

                Console.WriteLine();

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
                int[] array = RandomArray(MinDlinaArray, MaxDlinaArray, minRandomNumber, MaxRandomNumber);
                Console.WriteLine($"[{string.Join(", ", array)}]");

                Console.WriteLine();
                // Выводим получившееся метод 

                Console.WriteLine($"Количество четных чисел в рандомном массиве равно {AnEvenNumberInArray(array)}");

                Console.WriteLine();

                Console.WriteLine("Вы хотите еще раз набрать массив? Если да, введите 'да', иначе 'нет'");
                string? answer3 = Console.ReadLine();
                // Спрашиваем у пользователя, хочет ли он рандомный массив
                if (answer3.ToLower() == "да")
                {
                    repeatWhile2 = true;
                }
                else
                {
                    repeatWhile2 = false;
                    break;
                }
            }
        }

    }
    else if (num == 2)
    {
        Console.WriteLine("Вы выбрали 'Найти количество нечетных чисел в массиве'");
        if (answer == "да")
        {
            bool repeatWhile3 = true;
            while (repeatWhile3 == true)
            {

                Console.WriteLine("Введите длину массива -> ");
                int dlinaArray = Convert.ToInt32(Console.ReadLine());
                int[] array = PersonArray(dlinaArray);

                Console.WriteLine();

                Console.WriteLine("Массив");
                Console.WriteLine($"[{string.Join(", ", array)}]");

                Console.WriteLine();

                Console.WriteLine($"Количество нечетных чисел в массиве равно {AddNumberInArray(array)}");

                Console.WriteLine();

                Console.WriteLine("Вы хотите еще раз набрать массив? Если да, введите 'да', иначе 'нет'");
                string? answer4 = Console.ReadLine();
                if (answer4.ToLower() == "да")
                {
                    repeatWhile3 = true;
                }
                else
                {
                    repeatWhile3 = false;
                    break;
                }
            }
        }
        else
        {
            bool repeatWhile4 = true;
            while (repeatWhile4 == true)
            {

                Console.WriteLine();

                Console.WriteLine("Введите миниьальное рандомное число -> ");
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
                int[] array = RandomArray(MinDlinaArray, MaxDlinaArray, minRandomNumber, MaxRandomNumber);
                Console.WriteLine($"[{string.Join(", ", array)}]");

                Console.WriteLine();
                // Используем метод для нахождения нечтных чисел в массиве 
                Console.WriteLine($"Количество нечетных чисел в рандомном массиве равно {AddNumberInArray(array)}");

                Console.WriteLine();

                Console.WriteLine("Вы хотите еще раз набрать массив? Если да, введите 'да', иначе 'нет'");
                string? answer5 = Console.ReadLine();
                if (answer5.ToLower() == "да")
                {
                    repeatWhile4 = true;
                }
                else
                {
                    repeatWhile4 = false;
                    break;
                }
            }
        }
    }
    // если пользователь выбрал задачу под номером 3 найти количество четных  и нечетных чисел в массиве
    else if (num == 3)
    {
        Console.WriteLine("Вы выбрали 'Найти количество четных  и нечетных чисел в массиве'");
        if (answer == "да")
        {
            bool repeatWhile1 = true;
            while (repeatWhile1 == true)
            {

                Console.WriteLine("Введите длину массива -> ");
                int dlinaArray = Convert.ToInt32(Console.ReadLine());
                int[] array = PersonArray(dlinaArray);

                Console.WriteLine();

                Console.WriteLine("Массив");
                Console.WriteLine($"[{string.Join(", ", array)}]");

                Console.WriteLine();
                // Выводим результат при помощи метода AnEvenNumberInArray
                Console.WriteLine($"Количество четных чисел в массиве равно {AnEvenNumberInArray(array)}");
                // Выводим рузультат при помощи метода AddNumberInArray
                Console.WriteLine($"Количество нечетных чисел в массиве равно {AddNumberInArray(array)}");

                Console.WriteLine();

                Console.WriteLine("Вы хотите еще раз набрать массив? Если да, введите 'да', иначе 'нет'");
                string? answer6 = Console.ReadLine();
                if (answer6.ToLower() == "да")
                {
                    repeatWhile1 = true;
                }
                else
                {
                    repeatWhile1 = false;
                    break;
                }
            }
        }
        else
        {
            bool repeatWhile2 = true;
            while (repeatWhile2 == true)
            {

                Console.WriteLine();

                Console.WriteLine("Введите миниьальное рандомное число -> ");
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
                int[] array = RandomArray(MinDlinaArray, MaxDlinaArray, minRandomNumber, MaxRandomNumber);
                Console.WriteLine($"[{string.Join(", ", array)}]");

                Console.WriteLine();

                // Выводим результат при помощи метода AnEvenNumberInArray
                Console.WriteLine($"Количество четных чисел в рандомном массиве равно {AnEvenNumberInArray(array)}");
                // Выводим рузультат при помощи метода AddNumberInArray
                Console.WriteLine($"Количество нечетных чисел в массиве равно {AddNumberInArray(array)}");

                Console.WriteLine();

                Console.WriteLine("Вы хотите еще раз набрать массив? Если да, введите 'да', иначе 'нет'");
                string? answer7 = Console.ReadLine();
                if (answer7.ToLower() == "да")
                {
                    repeatWhile2 = true;
                }
                else
                {
                    repeatWhile2 = false;
                    break;
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Вы ввели не 1 и 2, и 3. Пожалуйста, попробуйте снова");
        Console.Write("Вы хотите продолжить? Если да введите 'да', иначе 'нет' -> ");
        string? answer8 = Console.ReadLine();
        if (answer8.ToLower() == "да")
        {
            repeatWhile = true;
        }
        else
        {
            repeatWhile = false;
            break;
        }
    }
    Console.Write("Вы хотите продолжить? Если да введите 'да', иначе 'нет' -> ");
    string? answer9 = Console.ReadLine();
    if (answer9.ToLower() == "да")
    {
        repeatWhile = true;
    }
    else
    {
        repeatWhile = false;
        break;
    }
}