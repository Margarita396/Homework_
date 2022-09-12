// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandom2dArray (int rows, int cols, int min, int max){
    double[,] array = new double[rows, cols];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < cols; j++){
            array[i,j] = Convert.ToDouble(new Random().Next(min,max)/10.0);
        }
    }
    return array;
}

void Show2dArray (double[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input numb of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandom2dArray (m, n, min, max);
Show2dArray (array);

// Не уверена в правильности решения данной задачи.


// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateNew2dArray (int rows, int cols, int min, int max){
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < cols; j++){
            array[i,j] = new Random().Next(min,max+1);
        }
    }
    return array;
}

void ShowNewArray (int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }
         Console.WriteLine();
    }
}

void CheckElement (int[,] array, int i, int j){
    if (i < array.GetLength(0) && j < array.GetLength(1)) Console.WriteLine($"Element at postion ({i},{j}) is {array[i,j]}.");
    else Console.WriteLine("No such element");
}

Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateNew2dArray (rows, cols, min, max);
ShowNewArray (array);

Console.Write("Input position i: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Input position j: ");
int j = Convert.ToInt32(Console.ReadLine());

CheckElement (array, i,j);

// Программа работает корректно.


// Задача 52. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void AverageCols (int[,] array){
    Console.Write("Среднее арифметическое каждого столбца соответстввенно: ");
    for (int j = 0; j < array.GetLength(1); j++){
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++){
            sum += array[i,j];
        } 
        double average = sum/array.GetLength(0);
        Console.Write(average + "; ");
    }
}

Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateNew2dArray (rows, cols, min, max);
ShowNewArray (array);
Console.WriteLine();
AverageCols (array);

// Программа вычисляет среднее арифметическое каждого столбца.