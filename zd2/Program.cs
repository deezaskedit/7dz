// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


int[,] CreateRandom2Array(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);   
        }
    }
    
    return newArray;
}
void ShowArray2(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        
        Console.WriteLine();
    }
}
void ShowValue(int[,]array, int row, int column)
{
    if(row < array.GetLength(0))
    {
        if (column < array.GetLength(1)) Console.WriteLine($"Your number is {array[row - 1,column - 1]}.");
    }
    else Console.WriteLine("There isn't such number.");
}
Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] newArray = CreateRandom2Array(m, n, min, max);
ShowArray2(newArray);
Console.WriteLine("Input row-position of the number: ");
int userRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input colum-position of the number: ");
int userColumn = Convert.ToInt32(Console.ReadLine());
ShowValue(newArray, userRow, userColumn);