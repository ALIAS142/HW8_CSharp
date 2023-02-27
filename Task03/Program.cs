// Задача 3 (58): Задайте две матрицы. Программа находит произведение двух матриц.


int[,] Matr1 = GetMatrix (4, 4, 1, 9);

int[,] Matr2 = GetMatrix (4, 4, 1, 9);

Print(Matr1);
Console.WriteLine();

Print(Matr2);
Console.WriteLine();
// Print(Matr);

Print( MatrixMulti(Matr1, Matr2));

// Рандомный int массив
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

int [,] MatrixMulti (int[,] Matr1, int[,] Matr2)
{
int[,] Matr = new int[Matr1.GetLength(0), Matr2.GetLength(1)];

    for (int i = 0; i < Matr1.GetLength(0); i++)
    {
        for (int j = 0; j < Matr2.GetLength(1); j++)
        {
            for (int l = 0; l < Matr2.GetLength(0); l++)
            {
                Matr[i, j] = Matr1[i, l] * Matr2[l, j];
            }
        }
    }
    return Matr;
}
