// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i <= N; i++)
// {
//     Console.Write($"{i} ");
// }

// string PrintNumbers(int num)
// {
//     string result = "";
//     for (int i = 0; i <= num; i++)
//     {
//         result += i.ToString() + " ";
//     }
//     return result;
// }
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(PrintNumbers(N));

// string PrintNumbersRecursion(int start, int end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return (start + " " + PrintNumbersRecursion(start+1, end));
// }
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(PrintNumbersRecursion(1, N));

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// string PrintNumbersRecursion(int start, int end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return (start + " " + PrintNumbersRecursion(start+1, end));
// }
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(PrintNumbersRecursion(M, N));

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// int SumRecursion(int number)
// {
//     if (number == 0) return 0;
//     return number % 10 + SumRecursion(number/10);
// }
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{N} -> {SumRecursion(N)}");

// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// int DegreeRecursion(int number, int degree)
// {
//     if (degree == 1)
//     {
//         return number;
//     }
//     return number * DegreeRecursion(number, degree-1);
// }
// Console.Write("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(DegreeRecursion(A, B));

// Домашнее задание

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int SumRecursion(int start, int end)
// {
//     if (start == end)
//     {
//         return start;
//     }
//     return (start + SumRecursion(start+1, end));
// }
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"M = {M}, N = {N} -> {SumRecursion(M, N)}");

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 

// int AkkermanRecursion(int l, int k)
// {
//     if (l == 0)
//     {
//         return k+1;
//     }
//     else if (l > 0 && k == 0)
//     {
//         return AkkermanRecursion(l - 1, 1);
//     }
//     return (AkkermanRecursion(l - 1, AkkermanRecursion(l, k - 1)));
// }
// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"m = {m}, n = {n} -> A(m, n) = {AkkermanRecursion(m, n)}");