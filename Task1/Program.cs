// Урок 7. Рекурсия

// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int M = ReadInt("Input number M: ");
    int N = ReadInt("Input number N: ");
    PrintNumbersBetweenMN(N, M);
}

void PrintNumbersBetweenMN(int numberN, int numberM)
{
    if (numberM > numberN || numberM == numberN)

        System.Console.Write($"{numberM} >= {numberN} condition is not true");
    else PrintAllRight(numberN, numberM);
    System.Console.Write($"\" ");
    PrintNumbersBetweentoMN(numberN, numberM);
    System.Console.Write($"\"");
}

void PrintNumbersBetweentoMN(int numberN, int numberM)
{
    if (numberN < numberM) return;
    PrintNumbersBetweentoMN(numberN - 1, numberM);

    System.Console.Write(numberN + ", ");

}

void PrintAllRight(int number1, int number2)
{
    System.Console.Write("N = " + number1 + "; M = " + number2 + " -> ");
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();

