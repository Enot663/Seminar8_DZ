// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();

int numRows = ReceivingData("Введите число строк массива: ");
int numColumns = ReceivingData("Введите число столбцов массива: ");
int numDeep = ReceivingData("Введите глубину массива: ");

int[,,] arrayCube = new int[numRows, numColumns, numDeep];
CompletingArrayCube(arrayCube);
DeclareArrayCube(arrayCube);


int ReceivingData(string message) // Ввод данных.
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void CompletingArrayCube(int[,,] arrayCube) // Заполняем матрицу.
{
    int[] temp = new int[arrayCube.GetLength(0) * arrayCube.GetLength(1) * arrayCube.GetLength(2)];// создаем одномерный
    // массив заполняемый произвольными двузначными числами
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j]) // исключаем из матрицы повторяющиеся числа
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }

        }
    }
    int count = 0; // счетчик  прогоняющий заполнение матрицы согласно введенных пользователем данных и определяющий
    // коодинаты элемента в матрице
    for (int numRows = 0; numRows < arrayCube.GetLength(0); numRows++)
    {
        for (int numColumns = 0; numColumns < arrayCube.GetLength(1); numColumns++)
        {
            for (int numDeep = 0; numDeep < arrayCube.GetLength(2); numDeep++)
            {
                arrayCube[numRows, numColumns, numDeep] = temp[count];
                count++;
            }
        }
    }
}

void DeclareArrayCube(int[,,] arrayCube) // Вывод матрицы на консоль.
{
    for (int i = 0; i < arrayCube.GetLength(0); i++)
    {
        for (int j = 0; j < arrayCube.GetLength(1); j++)        
        {            
            for (int k = 0; k < arrayCube.GetLength(2); k++)
            {
                Console.Write($" [{i},{j},{k}]: {arrayCube[i, j, k]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


