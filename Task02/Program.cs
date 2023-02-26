// Задача 2(56): Задайте прямоугольный двумерный массив. Программа находит строку с наименьшей суммой элементов.
int[,] matrix = GetMatrix (4, 8, 1, 9);
// Print(matrix);



//  Рандомный int массив
int [,] GetMatrix (int rows, int columns, int min, int max)
{
int [,] matrix = new int [rows, columns];
for (int i = 0; i < rows; i++)
{
for (int l = 0; l < columns; l++)
{
matrix [i, l] = new Random().Next(min, max + 1);
}
}
return matrix;
}

// Печать массива

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write(matrix[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}



int RowMinSumEl (int[,] matrix, int i)
{
  int rowcount = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    rowcount += matrix[i,j];
  }
  return rowcount;
}

int minRow = 0;
int rowcount = RowMinSumEl(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int temp = RowMinSumEl(matrix, i);
  if (rowcount > temp)
  {
    rowcount = temp;
    minRow = i;
  }
}

Print(matrix);
Console.WriteLine();

Console.WriteLine($" {minRow} ");