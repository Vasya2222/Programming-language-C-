// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
// ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.Write("Введите массив в одну строку через пробел (например, 1 2 3 4 5) -> ");
string array = Console.ReadLine();

var arr = array.Split(" ");
int count = 0;
for (int i = 0; i < arr.Length; i++){

    Console.Write(arr[i] + " ");
    if (int.Parse(arr[i]) > 0){
        count++;
    }
}

Console.WriteLine();
Console.WriteLine($"Количество чисел в массиве, которые больше 0 равняется {count}");