/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] arr = FillMultiDimArray();
PrintMultiDimArray(arr);
Console.WriteLine("");
int[] sum = new int[arr.GetLength(0)];
for (int i = 0; i < arr.GetLength(0); i++)
{
	int sumTemp = 0;
	for (int j = 0; j < arr.GetLength(1); j++)
	{
		sumTemp += arr[i, j];
	}
	sum[i] = sumTemp;
}
int minSum = sum[0];
int row = 0;
for (int i = 0; i < sum.Length; i++)
{
	if (sum[i] < minSum)
	{
		minSum = sum[i];
		row = i;
	}
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {row + 1} строка");


/* ----------------------------------------- */
int[,] FillMultiDimArray(int _m = 4, int _n = 4)
{
	int[,] array = new int[_m, _n];
	for (int i = 0; i < _m; i++)
	{
		for (int j = 0; j < _n; j++)
		{
			array[i, j] = new Random().Next(10);
		}
	}
	return array;
}
void PrintMultiDimArray(int[,] array)
{
	for (int i = 0; i < array.GetLongLength(0); i++)
	{
		for (int j = 0; j < array.GetLongLength(1); j++)
		{
			Console.Write($"{array[i, j]} | ");
		}
		Console.WriteLine("");
	}
}
