// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i <= N; i++)
// {
//     Console.Write($"{i} ");
// }
string PrintNumbers(int N)
{
    for (int i = 0; i <= N; i++)
    {
        Console.Write($"{i} ");
    }
}
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
