// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
void Numbers (int num, int num1){
    if (num == num1){
        return;
    }
    Console.Write(num + " ");
    Numbers(num + 1, num1);
    
}

Console.Write("Введите число минимальное -> ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число максимальное -> ");
int num1 = Convert.ToInt32(Console.ReadLine());

Numbers(num, num1);