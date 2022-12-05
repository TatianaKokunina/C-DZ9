/*  Задайте значение N. Напишите программу, которая выведет все натуральные
 числа в промежутке от N до 1. Выполнить с помощью рекурсии.*/
/*int getUserInt(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}
getUserInt("Введите N");
int Startnumber = getUserInt;*/


Console.Write("Введите N: "); 
int number = Convert.ToInt32(Console.ReadLine()); 

void NumberCounter(int number)
{
    if (number < 0) Console.WriteLine($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    NumberCounter(number - 1);
}

NumberCounter(number);