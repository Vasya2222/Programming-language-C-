// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


// спросить у пользователя, желает ли он сам ввести или нужно рандомное число
Console.WriteLine("Если Вы хотите ввести число введите -> да, если нет введите -> нет");
Console.Write("Введите ответ -> ");
string YesorNO = Console.ReadLine();

if (YesorNO.ToLower() == "да"){
    Console.Write("Введите трехзначное число -> ");
    int num = Convert.ToInt32(Console.ReadLine());
    if ((1000 > num && num > 100) || (-1000 < num && num < -100)){
        Console.WriteLine($"Второе число {num} равно -> {num % 100 / 10}");
    }
    else{
        Console.WriteLine("Нужно трехзначное число, попробуйте еще раз");
    }
}
else{
    int randomNum = new Random().Next(100, 1000);
    Console.WriteLine($"Случайное трехзначное число равняется {randomNum}");
    Console.WriteLine($"Второе число случайного чилсла {randomNum} равняется {randomNum % 100 / 10}");
}