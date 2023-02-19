// Показать двумерный массив размером m×n заполненный вещественными числами
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

double[,] InitMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * 10;
        }
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0:0.0}  ", matrix[i, j]);
        }
        Console.WriteLine();
    }
}
int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");
double[,] matrix = InitMatrix(m, n);

Console.WriteLine("Матрица:");

PrintMatrix(matrix);


