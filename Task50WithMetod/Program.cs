// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7->такого элемента в массиве нет

Console.Write("Введите номер строки: ");
bool inputFirst = int.TryParse(Console.ReadLine(), out int numberRows);

Console.Write("Введите номер столбца: ");
bool inputSecond = int.TryParse(Console.ReadLine(), out int numberColumns);

if (inputFirst && inputSecond)
{
    int[,] randomMatrix = GetFillMatrix(3, 4);
    PrintMatrix(randomMatrix);
    Console.WriteLine();
    FindElementPosition(randomMatrix, numberRows, numberColumns);
}
else Console.WriteLine($"Некорректный ввод!");

int[,] GetFillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random randomElement = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = randomElement.Next(10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i , j]);
        }
        Console.WriteLine(" ]");
        Console.WriteLine();
    }
}
void FindElementPosition(int[,] matrix, int positionRows, int positionColumns)
{
    if (positionRows <= matrix.GetLength(0) && positionColumns <= matrix.GetLength(1))
    {
        Console.WriteLine($"На позиции строка номер: {positionRows}, столбец номер: {positionColumns} " +
                          $"находится элемент со значением: {matrix[positionRows - 1, positionColumns - 1]}");
    }
    else Console.WriteLine($"Cтрока номер {positionRows}, столбец номер {positionColumns} - такой позиции в массиве нет.");
}