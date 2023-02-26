// Задача 1(54): Программа упорядочивает по убыванию элементы каждой строки двумерного массива.


int[,] Massiv = GetMatrix (4, 4, 1, 9);
Print(Massiv);
Console.WriteLine();
RowOrder(Massiv);
Print(Massiv);



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

// Упорядочивание строки

void RowOrder (int[,] matrix)

{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int l = 0; l < matrix.GetLength(1)-1; l++)
            {
                if (matrix[i,l] < matrix [i,l+1])
                {
                    int temp = matrix [i,l+1];
                    matrix [i,l+1] = matrix[i,l];
                    matrix[i,l] = temp;
                }
            }
            
        }
    }
}




