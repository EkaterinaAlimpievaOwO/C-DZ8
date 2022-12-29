// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Random random = new Random();
// int[,] matrix = CreateIntMatrix(random.Next(2, 5), random.Next(2, 5), 1, 10);
// Console.WriteLine("Заданный массив:");
// PrintIntMatrix(matrix);
// Console.WriteLine("Упорядоченный массив:");
// SortIntMatrix(matrix);
// PrintIntMatrix(matrix);


// ------------------------------------------------------------------------------->

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Random random = new Random();
// int[,] matrix = CreateIntMatrix(random.Next(2, 5), random.Next(2, 5), 1, 10);
// PrintIntMatrix(matrix);
// Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (FindMinSum(matrix) + 1));


// ------------------------------------------------------------------------------->

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Random random = new Random();
// int m = random.Next(2, 5);
// int n = random.Next(2, 5);
// int[,] matrix1 = CreateIntMatrix(2, 2, 1, 10);
// int[,] matrix2 = CreateIntMatrix(2, 2, 1, 10);
// PrintIntMatrix(matrix1);
// Console.WriteLine();
// PrintIntMatrix(matrix2);
// Console.WriteLine();
// PrintIntMatrix(MultiplyMatrix(matrix1, matrix2));


// ------------------------------------------------------------------------------->

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] array = Create3dArray(2, 2, 2, 10, 100);
// Print3dArray(array);

// ------------------------------------------------------------------------------->

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



int[,] spiralMatrix = CreateSpiralMatrix(4, 4);
PrintIntMatrix(spiralMatrix);




// ------------------------------------------------------------------------------->
int[,] CreateSpiralMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];

    int elementsLeft = m * n;
    int step = 0;
    int direction = 0;

    int topBorder = 0;
    int leftBorder = 0;
    int bottomBorder = m - 1;
    int rightBorder = n - 1;


    int i = 0;
    int j = 0;

    while (elementsLeft >= 0)
    {
        matrix[i, j] = step;
        step++;
        elementsLeft--;

        if (direction == 0)
        {
            if ((j + 1) <= rightBorder)
            {
                j++;
            }
            else
            {
                direction = 1;
                topBorder++;
            }
        }

        if (direction == 1)
        {
            if ((i + 1) <= bottomBorder)
            {
                i++;
            }
            else
            {
                direction = 2;
                rightBorder--;
            }
        }

        if (direction == 2)
        {
            if ((j - 1) >= leftBorder)
            {
                j--;
            }
            else
            {
                direction = 3;
                bottomBorder--;
            }
        }

        if (direction == 3)
        {
            if ((i - 1) >= topBorder)
            {
                i--;
            }
            else
            {
                direction = 0;
                leftBorder++;
            }
        }
        // PrintIntMatrix(matrix); // test
        // Console.WriteLine(); // test
    }

    return matrix;
}

void PrintUsedNumbers(int[] array)
{
    Console.Write("Использованные числа: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[,] CreateIntMatrix(int x, int y, int min, int max)
{
    Random random = new Random();
    int[,] matrix = new int[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrix[i, j] = random.Next(min, max);
        }
    }
    return matrix;
}

void PrintIntMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("|" + matrix[i, j] + "| ");
        }
        Console.WriteLine();
    }
}

void Print3dArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j, k] + "(" + i + ", " + j + ", " + k + ")");
            }
            Console.WriteLine();
        }
    }
}

int[,,] Create3dArray(int a, int b, int c, int min, int max)
{
    Random random = new Random();
    int usedIndex = 0;
    int[,,] matrix = new int[a, b, c];
    int[] usedNumbers = new int[matrix.Length];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                matrix[i, j, k] = GenerateUnique(min, max, usedNumbers, usedIndex);
                usedIndex++;
            }
        }
    }
    PrintUsedNumbers(usedNumbers);
    return matrix;
}

bool IsUnique(int[] array, int x)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (x == array[i])
        {
            return false;
        }
    }
    return true;
}

int GenerateUnique(int min, int max, int[] array, int index)
{
    Random random = new Random();
    int result = random.Next(min, max);
    if (IsUnique(array, result))
    {
        array[index] = result;
    }
    else
    {
        result = GenerateUnique(min, max, array, index);
    }
    return result;
}

void SortIntMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = matrix[i, 0];

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] > matrix[i, k])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}

int FindMinSum(int[,] matrix)
{
    int minSum = 0;
    int minIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }

        if (i == 0)
        {
            minSum = sum;
        }

        else
        {
            if (sum < minSum)
            {
                minSum = sum;
                minIndex = i;
            }
        }

    }
    return minIndex;
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resultMatrix;
}