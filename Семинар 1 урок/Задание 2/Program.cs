// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число -> ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число -> ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num < num1){
    Console.Write("Максимальное число из двух чисел равно -> ");
    Console.WriteLine(num1);
    Console.Write("Минимальное число из двух чисел равно -> ");
    Console.WriteLine(num);
}
else{
    Console.Write("Максимальное число из двух чисел равно -> ");
    Console.WriteLine(num);
    Console.Write("Минимальное число из двух чисел равно -> ");
    Console.WriteLine(num1);
}




