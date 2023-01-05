// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

void PrintArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void MultiArray(int[,] firstArray, int[,] secondArray, int[,] multiArray)
{
    for (int i = 0; i < multiArray.GetLength(0); i++)
    {
        for (int j = 0; j < multiArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sum = sum + firstArray[i, k] * secondArray[k, j];
            }
            multiArray[i, j] = sum; 

        }
    }
    
}

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//запраштваем у пользователя кол-во строк и столбцов первой матрицы
int firstMRows = EnterNumber("Введите количество строк первой матрицы: ");
int firstMColumns = EnterNumber("Введите количество столбцов первой матрицы: ");
int secondMRows = EnterNumber("Введите количество строк второй матрицы: ");
int secondMColumns = EnterNumber("Введите количество столбцов второй матрицы: ");
//создаем массив с помощью рандома
int[,] firstMatrix = CreateRandomArray(firstMRows, firstMColumns, 1, 10);
int[,] secondMatrix = CreateRandomArray(secondMRows, secondMColumns, 1, 10);
//создаем массив умножения матриц
int[,] multiMatrix = new int[firstMColumns, secondMRows];
// вывод двух массивов
PrintArray(firstMatrix);
Console.WriteLine();
PrintArray(secondMatrix);
Console.WriteLine();
// находим произведение двух матриц или выводим сообщение, что это нельзя сделать
if(firstMColumns != secondMRows) Console.WriteLine("Матрицы нельзя перемножить");
else
{
MultiArray(firstMatrix, secondMatrix, multiMatrix);
PrintArray(multiMatrix);
}
