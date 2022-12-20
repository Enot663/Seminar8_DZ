// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой
// строки двумерного массива.
Console.Clear();

int ReceivingData(string message) // Вводим данные двумерного массива
{
    Console.Write(message);
    int upshot = int.Parse(Console.ReadLine());
    return upshot;
}

void CompletingArray(int[,] array) // Заполняем массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void DeclareArray(int[,] array) // Вывод массива на консоль.
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        Console.Write($" {array[i, j]} ");        
      }
      Console.WriteLine();
   }
   
}

void OrderedMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < matrix.GetLength(1) - 1; z++)
            {
                if (matrix[i, z] < matrix[i, z + 1])    // сортировка в обратную сторону - 
                                                        // поменять знак < на противоположный
                {
                    int temp = 0;
                    temp = matrix[i, z];
                    matrix[i, z] = matrix[i, z + 1];
                    matrix[i, z + 1] = temp;
                }
            }
        }
    }
}

int numRows = ReceivingData("Введите число строк массива: ");
int numColumns = ReceivingData("Введите число столбцов массива: ");
int[,] matrix = new int[numRows, numColumns];

Console.WriteLine();
Console.WriteLine("Созданный массив: ");
Console.WriteLine();
CompletingArray(matrix);
DeclareArray(matrix);
Console.WriteLine();
Console.WriteLine("Упорядоченный массив: ");
Console.WriteLine();
OrderedMatrix(matrix);
DeclareArray(matrix);



