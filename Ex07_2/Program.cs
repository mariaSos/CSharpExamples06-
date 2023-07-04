// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

//Генерация массива
int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    var rand = new Random();
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
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
void PrintMatrix(int[,] matrix)
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

bool FindElement(int[,] matrix, int row, int col, out int number)
{
    number = 0;
    if (matrix.GetLength(0) < row || matrix.GetLength(1) < col)
    {
        return false;
    }
    else
    {
        number = matrix[row - 1, col - 1];
        return true;
    }
}
//.........................................................................
int[] size = ReadInt("Задайте количество строк и столбцов через запятую: ");
int[] range = ReadInt("Задайте левую и правую границы массива через запятую:  ");
int[,] matrix = FillMatrix(size[0], size[1], range[0], range[1]);

PrintMatrix(matrix);

int[] pos = ReadInt("Задайте номер строки и номер столбца искомого элемента через запятую:  ");

if (FindElement(matrix, pos[0], pos[1], out int number))
{
    System.Console.WriteLine($"Значение искомого элемента равно {number}");
}
else
{
    System.Console.WriteLine("Такого элемента не существует!");
}