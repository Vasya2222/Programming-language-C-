// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("Введите число -> ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Таблица кубов");

for (int i = 1; i <= num; i++){
    Console.WriteLine($"{i} в кубе равно -> {Math.Pow(i, 3)}");
}