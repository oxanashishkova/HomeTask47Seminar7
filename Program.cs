// Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами.
/* m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
 */

Console.WriteLine("Введите кол-во строк массива:");
var rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов массива:");
var columns = int.Parse(Console.ReadLine());

var array = GetArrayMatrix(rows, columns, -10, 10);
PrintArray(array);

double[,] GetArrayMatrix(int rows, int columns, int minValue, int maxValue)
{
double[,]result = new double[rows,columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    result[i, j] = new Random().NextDouble();
}
return result;
}

void PrintArray(double[,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
{
    for (int j = 0; j < inArray.GetLength(1); j++)

    {
        Console.Write($"{inArray[i, j]}  ");
    }
Console.WriteLine();
}
}
