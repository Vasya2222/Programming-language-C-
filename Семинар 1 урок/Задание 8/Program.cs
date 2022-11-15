// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Программа для нахождения всех четных чисел от 1 до n");

Console.WriteLine();

Console.Write("Введите число -> ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int count = 0;

Console.WriteLine();

Console.WriteLine("Все четные числа от 1 до n");

Console.WriteLine();

while(count <= n){ // пока count меньше n выпольнять
    if (count % 2 == 0){ // если count кратно двум выводить
        Console.WriteLine(count);
    }
    count++;
}
