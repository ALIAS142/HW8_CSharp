// Задача 62. Спираль


       
int numRows = SetNumber("Rows ");
int numColumns = SetNumber("Columns ");

var matrix = GetMatrix(numRows, numColumns);
// Print(matrix);

int SetNumber(string numberName)
{
Console.Write($"Enter number {numberName}: ");
int num = Convert.ToInt32(Console.ReadLine());
return num;
}

int [,] GetMatrix (int rows, int columns)
{
int [,] matrix = new int [rows, columns];
for (int i = 0; i < rows; i++)
{
for (int l = 0; l < columns; l++)
{
matrix [i, l] = i + l;
}
}
return matrix;
}

void Print(int [ , ] matrix)
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

    int n = 4;
    int[,] matrix2 = new int[n, n];

    int count = 1;
    int row = 0;
     int col = 0;

    SpiralMatrix(matrix2, ref count);

   Print(matrix2);

    int[,] SpiralMatrix(int[,] a, ref int count)
    {
        if (count <= a.GetLength(0) * matrix2.GetLength(1))
        {
            matrix2[row, col] = count;
            count++;
            if (row <= col + 1 && row + col < matrix2.GetLength(1) - 1) col++;
            else if (row < col && row + col >= matrix2.GetLength(0) - 1) row++;
            else if (row >= col && row + col > matrix2.GetLength(1) - 1) col--;
            else row--;
            SpiralMatrix(matrix2, ref count);
        }
        return matrix2;
    }

