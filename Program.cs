// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 1 -> 1
int InputInt(string massage)
{
    System.Console.WriteLine($"{massage} > ");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
int [,] GenerateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array) // печатаем массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }

}
int FindIndex (int[,] array, int ind1, int ind2)
{
    if(ind1<0|| ind2<0||ind1>array.GetLength(0)-1||ind2>array.GetLength(1)-1)
    {
        System.Console.WriteLine("Такого числа в масииве нет");
        return 0;
    }
    return array[ind1,ind2];
}
int r = InputInt("Введите количество строк");
int c = InputInt("Введите количество столбцов");
int[,] matrix =GenerateArray(r,c);
PrintArray(matrix);
int i = InputInt("Введите индекс строки");
int j = InputInt("Введите индекс столбца");

System.Console.WriteLine($" Ответ по задаче: { FindIndex(matrix,i,j)}");


