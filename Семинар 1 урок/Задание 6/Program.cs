// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Программа для проверки числа на четность");

Console.Write("Введите число -> ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0){
    Console.Write("Число ");
    Console.Write(num);
    Console.WriteLine(" -> четное");
}
else{
    Console.Write("Число ");
    Console.Write(num);
    Console.WriteLine(" -> нечетное");
}