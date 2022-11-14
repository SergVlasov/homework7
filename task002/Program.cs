// ## Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.*
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateArray(int row, int columns)
{
    int[,] numbers = new int[row, columns];
    return numbers;
}
void FillArray(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = new Random().Next(1, 100);
        }
    }
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
int[,] SearchNumber(int[,] array, int num1, int num2)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) ;
    }
    if (num1 > array.GetLength(0) | num1 < 0 | num2 > array.GetLength(1) | num2 < 0)
    {
        Console.WriteLine("There is no such element");
    }
    Console.WriteLine($"Element = {array.GetValue(num1, num2)}");
    return array;
}

int row = 4;
int columns = 4;
int[,] massiv = CreateArray(row, columns);
FillArray(massiv);
PrintArray(massiv);
Console.WriteLine("Enter the coordinate number of the element:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
SearchNumber(massiv, num1, num2);