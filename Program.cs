/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
int[,,] arr = FillMultiDimArray();
PrintMultiDimArray(arr);
int[,,] FillMultiDimArray(int _m = 2, int _n = 2, int _c = 2)
{
	int[,,] array = new int[_m, _n, _c];
	for (int i = 0; i < _m; i++)
	{
		for (int j = 0; j < _n; j++)
		{
			for (int k = 0; k < _c; k++)
			{
				array[i, j, k] = new Random().Next(10, 100);
			}

		}
	}
	return array;
}
void PrintMultiDimArray(int[,,] array)
{
	for (int i = 0; i < array.GetLongLength(0); i++)
	{
		for (int j = 0; j < array.GetLongLength(1); j++)
		{
			for (int k = 0; k < array.GetLongLength(2); k++)
			{
				Console.Write($"{array[i, j, k]} ({i},{j},{k}) | ");
			}
			Console.WriteLine("");
		}
	}
}
