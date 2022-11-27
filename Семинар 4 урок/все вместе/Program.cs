// задача: написать все задачи в одном проекте

// приветствуем пользователя
Console.WriteLine("Пожалуйста введите имя");
string name = Console.ReadLine();
Console.WriteLine("Привет, " + name);
bool true1 = true;
// true0 == true выполнять цикл
while(true1 == true){
    // объясняем что делает программа
    Console.WriteLine("Наша программа может делать 3 задачи");
    Console.WriteLine("1. Находит степень числа");
    Console.WriteLine("2. Находит сумму всех цифр в числе");
    Console.WriteLine("3. Выводит массив, которую Вы ввели или рандомные числа");
    Console.WriteLine("Полажуйста " + name + ",выберите задачу, введите цифру 1 или 2 или 3 -> ");
    int taskNum = Convert.ToInt32(Console.ReadLine());
    // если taskNum == 1 найти А в степени В
    if (taskNum == 1){

        bool true2 = true;            
        // оповещаем пользователя какую задачу он выбрал
        Console.WriteLine("Поздравляю " + name + ",вы выбрали задачу 1. Найти степень числа");

        // true6 == true выполнять цикл
        while(true2 == true){

            // метод по нахождению А в степени В
            int stepenNumAandB(int number1, int number2){
                int result = 1;

                for (int i = 0; i < number2; i++){
                    result *= number1;
                }
                return result;
                }

            Console.Write("Введите число -> ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите степень -> ");
            int B = Convert.ToInt32(Console.ReadLine());

            int result = stepenNumAandB(A, B);

            Console.WriteLine($"{A}^{B} = {result}"); 

            // узнаем дальнейшие действия пользователя
            Console.WriteLine();
            Console.Write("Вы хотите хотите еще раз найти число в степени? Если да, введите 'да', иначе 'нет' -> ");
            string? answer = Console.ReadLine();
            // Если пользователь ввел да, повторить программу
            if (answer.ToLower() == "да"){
                Console.WriteLine("Продолжаем :)");
                true2 = true;
            }
            // иначе не повоторять
            else{
                Console.WriteLine("Спасибо, что пользовались нашей программой");
                true2 = false;
                break;
            }
            }
        }
        
    

    else if (taskNum == 2){

        // оповещаем пользователя какую задачу он выбрал
        Console.WriteLine("Поздравляю " + name + ",вы выбрали задачу 2. Найти сумму цифр в числе");
        bool true3 = true;
        while(true3 == true){
            int sumNumber(int number){
            int sum = 0;
            // Если number меньше 0 то выполняем условие
            if (number < 0){
                int num1 = number;
                // ищем первую цифру числа
                while(number < -10){
                    number /= 10;
                }
                // суммируем все числа кроме первого
                while(num1 < -10){
                        sum += num1 % 10;
                        num1 /= 10;
                }
                // суммируем с первым числом и sum и возвращаем
                return (sum * -1) + number;
                }
            // иначе выполняем другое условие 
            else{
                // суммируем все числа
                while(number > 0){
                sum += number % 10;
                number /= 10;
                Console.WriteLine(sum);
                }
                // возращаем sum
                return sum;
                }
            }

            Console.Write("Введите число -> ");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = sumNumber(num);

            Console.WriteLine($"Сумма цифр в числе {num} равно {result}");

            Console.WriteLine();
            Console.Write("Вы хотите еще раз суммировать все цифры в числе? Если да, введите 'да', иначе 'нет' -> ");
            string? answer1 = Console.ReadLine();
            // Если пользователь ввел да, повторить программу
            if (answer1.ToLower() == "да"){
                Console.WriteLine("Продолжаем :)");
                true3 = true;
            }
            // иначе не повоторять
            else{
                Console.WriteLine("Спасибо, что пользовались нашей программой");
                true3 = false;
                break;
            }
            }
        }
        
    else if (taskNum == 3){
        // оповещаем пользователя какую задачу он выбрал
        Console.WriteLine("Поздравляю " + name + ",вы выбрали задачу 3. Вывести массив, которую Вы лично ввели или рандомные числа");
        bool true4 = true;
        // повторяем программу пока пользователь не введет нет
        while(true4 == true){
            Console.WriteLine("Пожалуйста, выберите, что Вы хотите, заполнить массив сами или рандомно. Если вы хотите заполнить введите 'да', иначе 'нет'");

            Console.Write("Введите ответ -> ");
            string? answer2 = Console.ReadLine();
            // если пользователь ввел да, значит хочет сам заполнить
            if (answer2.ToLower() == "да")
            {
                bool true5 = true;
                // пока пользователь не введет нет, повторять программу
                while (true5 == true)
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


                    Console.Write("Вы хотите еще раз заполнить массив? Если да, введите 'да', иначе 'нет' -> ");
                    string? answer3 = Console.ReadLine();
                    // Если пользователь ввел да, повторить программу
                    if (answer3.ToLower() == "да")
                    {
                        Console.WriteLine("Продолжаем :)");
                        true5 = true;
                    }
                    // иначе не повоторять
                    else
                    {
                        Console.WriteLine("Спасибо, что пользовались нашей программой");
                        true5 = false;
                        break;
                    }
                }

            }
            // если пользователь ввел нет, значит он хочет чтобы длина и числа заполнялить рандомно
            else if (answer2.ToLower() == "нет")
            {
                bool true6 = true;
                //повторять программу полностью до тех пор, пока пользователь не введет нет
                while (true6 == true)
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
                            Console.WriteLine();
                            Console.WriteLine(string.Join(" ", run3));
                        }
                        // если первое условие не выполнилось, выполняем следующее условие
                        else
                        {   
                            Console.WriteLine();
                            Console.WriteLine("Вы ввели не правилно диапазоны");
                            Console.Write("Вы хотите попробывать еще раз? Если да, введите 'да', иначе 'нет' -> ");
                            string? answer10 = Console.ReadLine();
                            //Если пользователь ввел да, выполняем следующее условие
                            if (answer10.ToLower() == "да")
                            {
                                Console.WriteLine("Продолжаем :)");
                                true6 = true;
                            }
                            //Если первое условие не выполнилось, выполняем другое условие
                            else
                            {
                                Console.WriteLine("Спасибо, что пользовались нашей программой");
                                true6 = false;
                                //прерываем программу т.к пользователь больше не хочет пользоваться программой
                                break;
                            }

                        }
                    Console.WriteLine();
                    Console.WriteLine("Вы хотите еще раз вывести массив? Если да, введите 'да', иначе 'нет'");
                    Console.Write("Введите ответ -> ");
                    string? answer5 = Console.ReadLine();
                    //Если пользователь ввел да, выполняем следующее условие
                    if (answer5 == "да")
                    {
                        Console.WriteLine("Продолжим :)");
                        true6 = true;
                    }
                    //Если первое условие не выполнилось, выполняем другое услови
                    else
                    {
                        Console.WriteLine("Спасибо, что пользовались нашей программой");
                        true6 = false;
                        break;
                    }

                }

            }
            // пользователь ввел не "да" и "нет", спрашиваем у пользователя, хочет ли он пропробывать еще раз
            else
            {
                Console.WriteLine();
                Console.WriteLine("Вы ввели не 'да' и 'нет', попробуйте еще раз");
                Console.Write("Вы хотите еще раз попробовать еще раз? Если да введите 'да', иначе 'нет' -> ");
                string? answer6 = Console.ReadLine();
                //Если пользователь ввел да, выполняем следующее условие
                if (answer6.ToLower() == "да")
                {
                    Console.WriteLine("Продолжаем :)");
                    true4 = true;
                }
                //Если первое условие не выполнилось, выполняем другое услови
                else
                {
                    Console.WriteLine("Спасибо, что пользовались нашей программой");
                    true4 = false;
                }
            }
        }
    }
    Console.WriteLine();
    Console.Write("Вы хотите пройти еще раз нашу программу? Если да, введите 'да', иначе 'нет' -> ");
    string? answer7 = Console.ReadLine();
    // Если пользователь ввел да, повторить программу
    if (answer7.ToLower() == "да"){
        Console.WriteLine("Продолжаем :)");
        true1 = true;
    }
    // иначе не повоторять
    else{
        Console.WriteLine("Спасибо, что пользовались нашей программой, жалко, что Вы уходите :(");
        true1 = false;
        break;
    }
    
}




