//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

string ResultNumber(int M, int N) 
{ 
    if (N == M) 
    { 
        return $"{M}"; 
    } 
    return ResultNumber(M, N - 1) + ", " + Convert.ToString(N); 
} 
Console.Write("Введите первое число: "); 
int M = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число: "); 
int N = Convert.ToInt32(Console.ReadLine()); 

void NumberSum(int N, int M, int sum)
{
    if (M > N) 
    { 
    Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {sum}"); 
    return;
    } 
    sum = sum + (M++);
    NumberSum(N,M,sum);
}
NumberSum(N,M,0);