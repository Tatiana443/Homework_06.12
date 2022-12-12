Console.WriteLine("Введите число строк  матрицы А: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов матрицы А и число строк матрицы В: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов матрицы В: ");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон случайных чисел: от 1 до: ");
int range = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = new int[m, n];
CreateArray(matrixA);
Console.WriteLine($"Матрица А:");
WriteArray(matrixA);

int[,] matrixB = new int[n, p];
CreateArray(matrixB);
Console.WriteLine($"Матрица В:");
WriteArray(matrixB);

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(matrixA, matrixB, resultMatrix);
Console.WriteLine($"Произведение матриц А и В:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] matrixA, int[,] matrixB, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}