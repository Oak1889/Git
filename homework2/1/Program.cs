int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Prompt("Введите трехзначное число ");

int number1 = number / 10;
int number2 = number1 % 10;
if (number >= 100 & number < 1000)
{
    System.Console.Write($"вторая цифра введенного числа - {number2}");
}
else
{
    System.Console.Write("Число не является трехзначным");
}
