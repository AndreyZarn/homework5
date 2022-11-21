// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int a = 0;
int b = 0;
int sum = 0;
int minsum = int.MaxValue;
int indexLine = 0;

void Rand()
{
    a = new Random().Next(4, 10);
    b = new Random().Next(4, 5);
}


void RandFillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 6);
        }
    }
}
void PrintArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void Minsumm(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
    
        if (sum < minsum)
        {
            minsum = sum;
            indexLine++;
        }
    }
}


Rand();
int[,] array = new int[a, b];
RandFillArray(array);
PrintArray2(array);
Minsumm(array);
Console.WriteLine("строка с наименьшей суммой элементов под номером: " + (indexLine) + ", с суммой элементов равной: " + (minsum));
