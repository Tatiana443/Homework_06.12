int[,] NewRndMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int[] SumElemsRow(int[,] matrix)
{
    int[] sumelems = new int[matrix.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            sumelems[i] = sum;
        }
        sum = 0;
    }
    return sumelems;
}

(int, int) TheSmallestSummaRow(int[] array)
{
    int resultSumma = array[0];
    int resultRow = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < resultSumma)
        {
            resultSumma = array[i];
            resultRow = i;
        }
    }
    return (resultRow, resultSumma);
}

int[,] matrix = NewRndMatrix(4, 4, 1, 9);
PrintMatrix(matrix);
int[] sumElemsRow = SumElemsRow(matrix);
Console.WriteLine();
(int, int) theSmallestSummaRow = TheSmallestSummaRow(sumElemsRow);
Console.WriteLine($"Строка -> {theSmallestSummaRow}");
