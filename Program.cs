/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */


int[,] matrixA = FillMultiDimArray();
int[,] matrixB = FillMultiDimArray();
PrintMultiDimArray(matrixA);
Console.WriteLine("");
PrintMultiDimArray(matrixB);
Console.WriteLine("");
int[,] matrixC = MatrixMultiplication(matrixA, matrixB);
PrintMultiDimArray(matrixC);




int[,] MatrixMultiplication(int[,] _matrixA, int[,] _matrixB)
{
	int[,] _matrixC = new int[_matrixA.GetLength(0), _matrixA.GetLength(1)];
	for (int k = 0; k < _matrixC.GetLength(0); k++)
	{
		for (int i = 0; i < _matrixC.GetLength(0); i++)
		{
			for (int j = 0; j < _matrixC.GetLength(1); j++)
			{
				_matrixC[k, i] += _matrixA[k, j] * _matrixB[j, i];
			}
		}
	}

	return _matrixC;
}



int[,] FillMultiDimArray(int _m = 2, int _n = 2)
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
