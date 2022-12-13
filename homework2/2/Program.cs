//Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета
// -> 46
//782 -> 72
//918 -> 98
int number = new Random().Next(99, 999);
int number1 = number / 100;
int number2 = number % 10;
int NumberFinal = number1 * 10 + number2;
System.Console.WriteLine($"радномное число {number}");
System.Console.WriteLine($"вторая цифра удалена {NumberFinal}");