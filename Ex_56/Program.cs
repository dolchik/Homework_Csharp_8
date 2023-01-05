// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void FindMinRow(int[,] array)
{
    int minRow = 0;
    int sumMinRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumMinRow = sumMinRow + array[0, j];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow = sumRow + array[i, j];
        }
        if(sumMinRow > sumRow)
        {
            sumMinRow = sumRow;
            minRow = i;
        }
    }
    System.Console.WriteLine($"Строка с наименьшой суммой элементов : {minRow + 1}");
}

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

void ChangeArray(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        temp = array[0,i];
        array[0,i] = array[array.GetLength(0)-1,i];
        array[array.GetLength(0)-1,i] = temp;
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

//запраштваем у пользователя кол-во строк и столбцов
int rows = EnterNumber("Введите количество строк массива: ");
int columns = EnterNumber("Введите количество столбцов массива: ");
//создаем массив с помощью рандома
int[,] matrix = CreateRandomArray(rows, columns, 1, 10);
//выводим массив
PrintArray(matrix);
//находим сумму каждой строки и выводим минимальную строку
Console.WriteLine();
FindMinRow(matrix);
