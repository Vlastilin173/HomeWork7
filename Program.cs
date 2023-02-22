// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
            matrix[i, j] = new Random ().Next (-10, 10) + new Random ().NextDouble ();
            matrix [i, j] = Math.Round (matrix [i, j], 1);
            }
    }

}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет
// 1 2 -> На данной позиции находиться элемент 4

Console.Clear();
Console.WriteLine("Введите номер строки для поиска элемента в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца для поиска элемента в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [4,4];
Elements(matrix);

Console.WriteLine("Начальный массив: ");
PrintArray(matrix);

if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
{
    Console.WriteLine("Такой позиции в массиве нет");
}
    else
    {
        Console.WriteLine($"Значение элемента: {matrix[n-1,m-1]}");
    }



void Elements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix [i,j] = new Random().Next(0, 10);
            }   
        }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }   
        Console.WriteLine(""); 
    }
}



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[n, m];

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Среднее арифметическое каждого столбца: ");
InputMatrix(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double stolbecSum = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        stolbecSum = (stolbecSum + numbers[i, j]);
    }
    stolbecSum = stolbecSum / n;
    Console.Write(stolbecSum + "; ");
}
Console.WriteLine();
Console.WriteLine("Начальный массив: ");
PrintArray(numbers);