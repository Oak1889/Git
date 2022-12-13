//Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Не использовать строки
//6 -> да
//7 -> да
//1 -> нет


System.Console.WriteLine("Введите цифру от 1 до 7");

int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 & number <= 5)
{
    System.Console.WriteLine("нет");
}

if (number > 5 & number <= 7)
{
    System.Console.WriteLine("да");
}

if (number > 7)
{
    System.Console.WriteLine("не та цифра");
}
