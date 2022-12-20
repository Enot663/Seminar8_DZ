// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

void ResultFindingMinimumAmount(int[,] matrix) // Метод сравнения строк.
{
    int minSumLine = 0;
    int sumLine = SumLineElements(matrix, 0);
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(matrix, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }
    Console.WriteLine($"В {minSumLine+1} - строке с наименьшая сумма {sumLine} элементов. ");
}

int SumLineElements(int[,] matrix, int i) // Метод подсчета суммы элементов в строке.
{
  int sumLine = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumLine += matrix[i,j];
  }
  return sumLine;
}



int numRows = ReceivingData("Введите число строк массива: ");
int numColumns = ReceivingData("Введите число столбцов массива: ");
int[,] matrix = new int[numRows, numColumns];


Console.WriteLine();
Console.WriteLine("Созданный массив: ");
Console.WriteLine();
CompletingArray(matrix);
DeclareArray(matrix);

ResultFindingMinimumAmount(matrix);
DeclareArray(matrix);
