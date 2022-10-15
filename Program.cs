/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
int[,] arr = FillMultiDimArray();
PrintMultiDimArray(arr);
Console.WriteLine("");
SelectionSort(arr);
PrintMultiDimArray(arr);

void SelectionSort(int[,] array)
{
	for (int g = 0; g < array.GetLength(0); g++)
	{
		for (int i = 0; i < array.GetLength(1); i++)
		{
			for (int j = i + 1; j < array.GetLength(1); j++)
			{
				if (array[g, i] < array[g, j])
				{
					int temp = array[g, j];
					array[g, j] = array[g, i];
					array[g, i] = temp;
				}
			}
		}
	}
}









int[,] FillMultiDimArray(int _m = 3, int _n = 4)
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
