// Задача 4 (60). Сформируйте трехмерный массив из неповторяющихся двухзначных чисел.
// Программа, которая построчно выводит массив, добавляя индексы каждого элемента.

int numRows = SetNumber("Rows ");
int numColumns = SetNumber("Columns ");
int numZSpindle = SetNumber("Z spindle");

var matrix = TripleMatrix(numRows, numColumns, numZSpindle);
Print(matrix);

int SetNumber(string numberName)
{
Console.Write($"Enter number {numberName}: ");
int num = Convert.ToInt32(Console.ReadLine());
return num;
}

int[, ,] TripleMatrix(int x, int y, int z)
{
    int[, ,] matrix = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int l = 0; l < y; l++)
        {
            for (int j = 0; j < z; j++)
            {
                matrix[i, l, j] = i + l + j;
            }
        }
    }
    return matrix;
}
void Print(int [, ,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int l = 0; l < matrix.GetLength(1); l++)
{
for (int j = 0; j < matrix.GetLength(2); j++)
    {
       System.Console.Write(matrix[i, l, j] + " ");
       
    }


}

System.Console.WriteLine();

}
}

void Print2(int [, ,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int l = 0; l < matrix.GetLength(1); l++)
{
for (int j = 0; j < matrix.GetLength(2); j++)
    {
       System.Console.Write ($"{matrix[i, l, j]} + {i} {l} {j}");
    
    }
}
}
}