// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели от 1 до 7 ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

if (dayWeek == 6 || dayWeek == 7){
    Console.WriteLine("Да");
}

else if (dayWeek < 1 || dayWeek > 7){
    Console.WriteLine("Вы ввели не день недели");
}
else{
    Console.WriteLine("Нет");
}