/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
/* int[,] arr = FillMultiDimArraySpiral(); */
int[,] arr = FillMultiDimArraySpiral();
PrintMultiDimArray(arr);


int[,] FillMultiDimArraySpiral(int _m = 4, int _n = 4)
{
	int[,] array = new int[_m, _n];
	int row = 0;
	int col = 0;
	int directionX = 1;
	int directionY = 0;
	int directionChangeCount = 0;
	int visitCount = _m;
	for (int i = 0; i < array.Length; i++)
	{
		array[row, col] = i + 1;
		if (--visitCount == 0)
		{
			visitCount = _m * (directionChangeCount % 2) + _n * ((directionChangeCount + 1) % 2) - (directionChangeCount / 2 - 1) - 2;
			int temp = directionX;
			directionX = -directionY;
			directionY = temp;
			directionChangeCount++;
		}

		col += directionX;
		row += directionY;
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
