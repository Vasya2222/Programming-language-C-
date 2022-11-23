// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

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
