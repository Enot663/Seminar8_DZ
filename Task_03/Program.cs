// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();

int ReceivingData(string message) // Вводим размерность матрицы.
{
    Console.Write(message);
    int upshot = int.Parse(Console.ReadLine());
    return upshot;
}

void CompletingArray(int[,] array) // Заполняем матрицу.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void DeclareArray(int[,] array) // Вывод матрицы на консоль.
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");        
        }
         Console.Write("]");
        Console.WriteLine();
   }   
}

int numMatrix = ReceivingData("Введите размерность матриц: ");
int[,] matrA = new int[numMatrix, numMatrix];
int[,] matrB = new int[numMatrix, numMatrix];
CompletingArray(matrA);
CompletingArray(matrB);
int[,] matrC = new int[numMatrix, numMatrix];
    
for (int i = 0; i < numMatrix; i++)
{
    for (int j = 0; j < numMatrix; j++)
    {
        for (int k = 0; k < numMatrix; k++)
        {
            matrC[i, j] = matrC[i, j] + (matrA[i, k] * matrB[k, j]);                
        }
    }
}
    




Console.WriteLine(" А - матрица: ");
DeclareArray(matrA);
Console.WriteLine();
Console.WriteLine(" В - матрица: ");
DeclareArray(matrB);
Console.WriteLine();
Console.WriteLine(" ВЫВОД ");
DeclareArray(matrC);

