/*Задача 64: Задайте значение N. Напишите программу,
 которая выведет все натуральные числа в промежутке от N до 1. 
 Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    System.Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return result;
}
string RecNatNum(int n, string res)
{
    if (n > 0)
    {
        res = n + ", " + RecNatNum(n - 1, res);
    }
    return res;
}
int x = GetDataFromUser("Введите число N");
string res = string.Empty;
res = RecNatNum(x, res);
res = '"' + res[..^2] + '"';
Console.WriteLine(res);