// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число -> ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 1000 || num < -1000){
    int num1 = num;
    while(num > 1000  ||  num < -1000){
        num /= 10;
    }
    Console.WriteLine($"Третья цифра числа {num1} равняется {num % 10}");
}
else if ((num > 100 && num < 1000) || (num < -100 && num > -1000)){
    Console.WriteLine($"Третья цифра числа {num} равняется {num % 10}");
}

else{
    Console.WriteLine("Третьего числа нет");
}