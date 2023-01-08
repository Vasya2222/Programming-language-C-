// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Numbers (int num, int num1){
    if (num == 0) return num1 + 1;
    if (num != 0 && num1 == 0) return Numbers(num - 1, 1);
    if (num > 0 && num1 > 0) return Numbers(num - 1, Numbers(num, num1 - 1));
    return Numbers(num, num1);
    
}

Console.Write("Введите число минимальное -> ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число максимальное -> ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана для чисел A({num},{num1}) = {Numbers(num, num1)}");