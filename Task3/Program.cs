// Урок 7. Рекурсия

// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

void Main()
{
    int arraySize = ReadInt("Input size array: ");
    int[] array = GenerateArray(arraySize, 0, 50);
    PrintArray(array);
    ElementsFromEnd(array, array.Length - 1);
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.Write("[" + string.Join(", ", arrayForPrint) + "] =>");
}

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    return tempArray;
}


int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void ElementsFromEnd(int[] myArray, int index)
{
    if (index < 0) return;
    System.Console.Write(myArray[index] + " ");
    ElementsFromEnd(myArray, index - 1);
}

Main();


















