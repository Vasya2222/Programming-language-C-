// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Программа для заполнения и вывод массива");

bool true1 = true;
// повторяем программу пока пользователь не введет нет
while(true1 == true){
    Console.WriteLine("Пожалуйста, выберите, что Вы хотите, заполнить массив сами или рандомно. Если вы хотите заполнить введите 'да', иначе 'нет'");

    Console.Write("Введите ответ -> ");
    string? otvet = Console.ReadLine();
    // если пользователь ввел да, значит хочет сам заполнить
    if (otvet.ToLower() == "да")
    {
        bool true2 = true;
        // пока пользователь не введет нет, повторять программу
        while (true2 == true)
        {
            Console.Write("Введите длину массива -> ");
            int lenghtArray = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[lenghtArray];

            // заполняем массив
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите {i} элемент -> ");
                int alementArray = Convert.ToInt32(Console.ReadLine());
                array[i] = alementArray;
            }

            Console.WriteLine(string.Join(" ", array));


            Console.Write("Вы хотите попробывать еще раз? Если да, введите 'да', иначе 'нет' -> ");
            string? otvet22 = Console.ReadLine();
            // Если пользователь ввел да, повторить программу
            if (otvet22.ToLower() == "да")
            {
                Console.WriteLine("Продолжаем :)");
                true2 = true;
            }
            // иначе не повоторять
            else
            {
                Console.WriteLine("Спасибо, что пользовались нашей программой, жалко, что Вы уходите :(");
                true2 = false;
            }
        }

    }
    // если пользователь ввел нет, значит он хочет чтобы длина и числа заполнялить рандомно
    else if (otvet.ToLower() == "нет")
    {
        bool true3 = true;
        //повторять программу полностью до тех пор, пока пользователь не введет нет
        while (true3 == true)
        {
            bool true4 = true;
            //повторять программу частично т.к пользователь неправильно ввел занчения до тех пор, пока пользователь не введет нет
            while (true4 == true)
            {

                Console.WriteLine("Пожалуйтса введите диапазон чисел и диапазон длины массива");

                //вводим диапазон чисел в массиве
                Console.WriteLine("Введите диапазон чисел");
                Console.Write("Диапазон минимального числа -> ");
                int run = Convert.ToInt32(Console.ReadLine());
                Console.Write("Диапазон максимального числа -> ");
                int run1 = Convert.ToInt32(Console.ReadLine());

                //вводим диапазон длины массива
                Console.WriteLine("Введите диапазон длины массива");
                Console.Write("Диапазон минимального длины массива -> ");
                int lenghtARRAY = Convert.ToInt32(Console.ReadLine());
                Console.Write("Диапазон максимального длины массива -> ");
                int lenghtARRAY1 = Convert.ToInt32(Console.ReadLine());

                //Если run меньше run1 и lenghtARRAY меньше lenghtARRAY1, выполнять слудующее
                if (run < run1 && lenghtARRAY < lenghtARRAY1)
                {
                    //задаем рандомное длину массива
                    int[] run3 = new int[new Random().Next(lenghtARRAY, lenghtARRAY1)];
                    for (int i = 0; i < run3.Length; i++)
                    {
                        //заполняем рандомными числами массива
                        int run4 = new Random().Next(run, run1);
                        run3[i] = run4;
                    }
                    Console.WriteLine(string.Join(" ", run3));
                }
                // если первое условие не выполнилось, выполняем следующее условие
                else
                {
                    Console.WriteLine("Вы ввели не правилно диапазоны");
                    Console.Write("Вы хотите попробывать еще раз? Если да, введите 'да', иначе 'нет' -> ");
                    string? otvet22 = Console.ReadLine();
                    //Если пользователь ввел да, выполняем следующее условие
                    if (otvet22.ToLower() == "да")
                    {
                        Console.WriteLine("Продолжаем :)");
                        true4 = true;
                    }
                    //Если первое условие не выполнилось, выполняем другое условие
                    else
                    {
                        Console.WriteLine("Спасибо, что пользовались нашей программой, жалко, что Вы уходите :(");
                        true4 = false;
                        //прерываем программу т.к пользователь больше не хочет пользоваться программой
                        break;
                    }

                }
            }

            Console.WriteLine("Вы хотите повторить? Если да, введите 'да', иначе 'нет'");
            Console.Write("Введите ответ -> ");
            string? otvet2 = Console.ReadLine();
            //Если пользователь ввел да, выполняем следующее условие
            if (otvet2 == "да")
            {
                Console.WriteLine("Продолжим :)");
                true3 = true;
            }
            //Если первое условие не выполнилось, выполняем другое услови
            else
            {
                Console.WriteLine("Спасибо, что пользовались нашей программой, жалко, что Вы уходите :(");
                true3 = false;
            }

        }

    }
    // пользователь ввел не "да" и "нет", спрашиваем у пользователя, хочет ли он пропробывать еще раз
    else
    {
        Console.WriteLine("Вы ввели не 'да' и 'нет', попробуйте еще раз");
        Console.Write("Вы хотите еще раз попробовать еще раз? Если да введите 'да', иначе 'нет' -> ");
        string? otvet5 = Console.ReadLine();
        //Если пользователь ввел да, выполняем следующее условие
        if (otvet5.ToLower() == "да")
        {
            Console.WriteLine("Продолжаем :)");
            true1 = true;
        }
        //Если первое условие не выполнилось, выполняем другое услови
        else
        {
            Console.WriteLine("Спасибо, что пользовались нашей программой, жалко, что Вы уходите :(");
            true1 = false;
        }
    }
}

