//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*Console.WriteLine("Введите натуральное число больше 1:");
int a = int.Parse(Console.ReadLine()!);

void AmountNumbers (int a)
{
    if (a < 0) Console.Write($"{a} не натуральное число");
    if (a == 0) return;
    Console.Write(a);
    AmountNumbers (a - 1);
}

AmountNumbers(a);*/


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*Console.WriteLine("Введите начальное число M:");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите начальное число N:");
int N = int.Parse(Console.ReadLine()!);

void FindSum (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N равна {sum}"); 
        return;
    }
    sum = sum + (M++);
    FindSum(M, N, sum);
}

FindSum(M, N, 0);*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*Console.WriteLine("Введите начальное число M:");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите начальное число N:");
int n = int.Parse(Console.ReadLine()!);

int Akkerman (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
return Akkerman(m, n);
}

Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {Akkerman(m, n)}");*/