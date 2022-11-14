// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray(int n, int m)
{
    int[,] massiv = new int[n, m];
    return massiv;
}
int[,] FillArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1, 50);
        }
    }
    return numbers;
}
void PrintArray(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write(massiv[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] ColAverage(int[,] massiv)
{
   
    double average = 0;
    int pows = 3;
    int i = 0;
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
         double sum = 0;
        for (i = 0; i < massiv.GetLength(0); i++ )
        {
            sum = sum + massiv[i,j];
            average = Math.Round((sum / pows), 1);
        }
        Console.WriteLine($"Сумма:{sum} Среднеарифм:{average} ");
    }
    return massiv;
}

int pows = 3;
int columns = 5;
Console.Clear();
int[,] array = CreateArray(pows, columns);
FillArray(array);
PrintArray(array);
ColAverage(array);