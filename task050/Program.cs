/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет*/

double[,] NewMatrixArrRand(int a, int b)//создает массив заполнненный псевдослучайными вещественными числами числами в интервале от 'a' до 'b'
{
    Random rnd = new Random();
    int line = rnd.Next(3, 10);//случайная размерность строк массива
    int column = rnd.Next(3, 10);//случайная размерность сстолбцов массива
    double[,] newArr = new double[line, column];

    for (int i = 0; i < line; i++)
    {
        for (int ind = 0; ind < column; ind++)
        {
            double value = rnd.NextDouble() + rnd.Next(a, b);
            newArr[i, ind] = value;
        }
    }
    return newArr;
}
void MatrixPrintArray(double[,] array)// печать двумерного массива double, в виде таблицы
{

    for (int ind = 0; ind < array.GetLength(0); ind++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            if (i == array.GetLength(1) - 1) Console.WriteLine($" {array[ind, i],6:f1}");
            else Console.Write($"{array[ind, i],6:f1}");
        }

    }
}
string OutPosition(double[,] arr, int line, int column)//выводит значение из массива число округленное до десятых в виде строки
{
    if (line <= arr.GetLength(0) && column <= arr.GetLength(1)) return Convert.ToString(Math.Round(arr[line-1, column-1], 1));
    else return "такого числа в массиве нет";
}
Console.Clear();
Console.Write("Задайте строку элемента в двумерном массиве : ");//показалось, что вывод при таком запросе будет более нагляден для пользователя, где значение первого элемента будет не 0,0, а 1,1 (возможно не прав)
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте столбец элемента в двумерном массиве : ");//
int column = Convert.ToInt32(Console.ReadLine());
double[,] array = NewMatrixArrRand(-10, 10);
string rezult = OutPosition(array, line, column);
MatrixPrintArray(array);
Console.WriteLine($"{line}, {column} -> {rezult}");
