// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


int stepenNumAandB(int number1, int number2){
    int result = 1;

    for (int i = 0; i < number2; i++){
        result *= number1;
    }
    return result;
}

Console.Write("Введите число -> ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень -> ");
int B = Convert.ToInt32(Console.ReadLine());

int result = stepenNumAandB(A, B);

Console.WriteLine($"{A}^{B} = {result}");