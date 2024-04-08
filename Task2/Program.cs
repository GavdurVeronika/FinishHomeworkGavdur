// Урок 7. Рекурсия

// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n

void Main()
{
    int m = ReadInt("Input number m: ");
    int n = ReadInt("Input number n: ");
    System.Console.Write("m = " + m + ", n = " + n + " -> A(m,n) = ");
    System.Console.Write(Ackerman(m, n));
}

int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackerman(m - 1, 1);
    }
    else
    {
        return (Ackerman(m - 1, Ackerman(m, n - 1)));
    }
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
Main();

