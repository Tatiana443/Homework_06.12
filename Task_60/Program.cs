void PrintMatrix(int[,,] matrix, int indexI, int indexJ, int indexK)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (j < matrix.GetLength(1) - 1)
                    Console.Write($"{matrix[i, j, k],4} ({i}, {j}, {k}) ");
                else Console.Write($"{matrix[i, j, k],4} ({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine("]");
    }
}

int[] ConvertMatrixToArray(int rows, int columns, int dept, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[rows * columns * dept];
    for (int i = 0; i < rows * columns * dept; ++i)
    {
        bool elementsUnique;
        do
        {
            array[i] = rnd.Next(min, max);
            elementsUnique = true;
            for (int j = 0; j < i; ++j)
                if (array[i] == array[j])
                {
                    elementsUnique = false;
                    break;
                }
        } while (!elementsUnique);
    }
    return array;
}

(int[,,], int, int, int) NewMatrix(int[] array, int row, int columns, int dept)
{
    int[,,] matrix2 = new int[row, columns, dept];
    int x = 0;
    int indexI = 0;
    int indexJ = 0;
    int indexK = 0;
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(2); k++)
            {
                matrix2[i, j, k] = array[x];
                indexI = i;
                indexJ = j;
                indexK = k;
                x++;
            }
        }
    }
    return (matrix2, indexI, indexJ, indexK);
}
int[] array = ConvertMatrixToArray(2, 2, 2, 10, 99);
(int[,,] matrix3, int i, int j, int k) = NewMatrix(array, 2, 2, 2);
Console.WriteLine($"Результат:");
Console.WriteLine();
PrintMatrix(matrix3, i, j, k);