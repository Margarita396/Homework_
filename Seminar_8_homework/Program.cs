int[,] CreateNew2dArray (int rows, int cols, int min, int max){
    int[,] array = new int[rows,cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i,j] = new Random().Next(min, max+1);
    return array;
}

void Show2dArray (int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

int[,] OrderedArray (int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(1)-1; k++){
                int tmp = 0;
                if (array[i,k] < array[i,k+1]){
                    tmp = array[i,k];
                    array[i,k] = array[i,k+1];
                    array[i,k+1] = tmp;
                }
            }
        }
    }
    return array;
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateNew2dArray (rows, cols, min, max);
Show2dArray (array);
Console.WriteLine();
int[,] arrayNew = OrderedArray (array);
Show2dArray (arrayNew);


// Задача 56: 
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void MinSumRow (int[,] array){
    int k = 1;
    int sumMin = 0;
    for (int i = 0; i < array.GetLength(0); i++){
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++){
            sum += array[i,j];
        }
        if (i == 0) sumMin = sum;
        else if (sum < sumMin){
            sumMin = sum;
            k = i + 1;
        }
    }
    Console.WriteLine($"Минимаьная сумма элементов в строке {k}");
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
if (rows<cols || rows>cols){
    Console.Write("Input min: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = CreateNew2dArray (rows, cols, min, max);
    Show2dArray (array);
    Console.WriteLine();
    MinSumRow (array);
}
else Console.WriteLine("Задайте прямоугольный массив");


// Задача 62:
// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] SquareSpiralArray (){
    int m = 4;
    int n = 4;
    int[,] array = new int[m,n];

    int k = 1;

    int iStart = 0, jStart = 0;
    int iStop = 0, jStop = 0;

    int i = 0;
    int j = 0;

    while (k <= m*n){
        array[i,j] = k;

        if (i == iStart && j < n-1-jStop) j++;
        else if (j == n-1-jStop && i < m-1-iStop) i++;
        else if (i == m-1-iStop && j > jStart) j--;
        else i--;

        if (i == iStart+1 && j == jStart){
            iStart++;
            jStart++;
            iStop++;
            jStop++;
        }
        k++;
    }
    return array;
}

int[,] spiralArray = SquareSpiralArray();
Show2dArray (spiralArray);


