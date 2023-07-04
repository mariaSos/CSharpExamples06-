//Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце

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
//Печать двумерного массива
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

//Печать одномерного массива
void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
//Среднеарифметическое всех столбцов
double[] AvgArray(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    double avg = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            avg = avg + matrix[j, i];
            if (j == matrix.GetLength(0) - 1)
            {

                array[i] = avg / matrix.GetLength(0);
                avg = 0;
            }

        }

    }
    return array;
}

//.....................
int[] size = ReadInt("Задайте количество строк и столбцов через запятую: ");
int[] range = ReadInt("Задайте левую и правую границы массива через запятую:  ");
int[,] matrix = FillMatrix(size[0], size[1], range[0], range[1]);

PrintMatrix(matrix);

double[] array = AvgArray(matrix);
Console.WriteLine("");
PrintArray(array);