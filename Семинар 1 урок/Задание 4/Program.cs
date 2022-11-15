// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Программа по нахождению максимльного числа из трех чисел");

Console.Write("Введите первое число -> ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число -> ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число -> ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (max < number2) max = number2; // Если max меньше чем number2, то max равно number2
if (max < number3) max = number3; // Если max меньше чем number3, то max равно number3


// Выводим максимальное число из трех чисел
Console.Write("Максимальное число равно -> ");
Console.WriteLine(max);