//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

//Генерация массива
double[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    double[,] tempMatrix = new double[row, col];
    var rand = new Random();
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] =
            Math.Round(rand.NextDouble() + rand.Next(leftRange, rightRange + 1), 3);
        }
    }
    return tempMatrix;
}
//Ввод данных
int[] ReadInt(string text)
{
    System.Console.Write(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse); ;
}
//Печать массива
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
//.........................................................................
int[] size = ReadInt("Задайте количество строк и столбцов через запятую: ");
int[] range = ReadInt("Задайте левую и правую границы массива через запятую:  ");

double[,] matrix = FillMatrix(size[0], size[1], range[0], range[1]);

PrintMatrix(matrix);
