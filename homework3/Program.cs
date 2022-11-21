int a = 0;
int b = 0;
int num = 1;
int i = 0;
int j = 0;
int size = 0;


void Rand()
{
    a = new Random().Next(4, 5);
    b = new Random().Next(4, 5);
}

void FiilArrayspire(int[,] array)
{
    while (num <= size * size)
    {
        array[i, j] = num;
        if (i <= j + 1 && i + j < size - 1)
            ++j;
        else if (i < j && i + j >= size - 1)
            ++i;
        else if (i >= j && i + j > size - 1)
            --j;
        else
            --i;
        ++num;
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



Rand();
int[,] array = new int[a, b];
size = array.GetLength(0);
FiilArrayspire(array);
PrintArray2(array);