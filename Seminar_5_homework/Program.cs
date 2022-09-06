// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] Array (int size){
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray (int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

int Even (int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

Console.WriteLine("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = Array (size);
ShowArray (array);
Console.WriteLine();

int even = Even (array);
Console.WriteLine($"Amount of even numbers: {even}.");

// Программа работает.


//Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] Array (int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray (int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

int Sum (int[] array){
    int sum = 0;
    for (int i = 0; i < array.Length; i++){
        if (i % 2 > 0) sum += array[i];
    }
    return sum;
}

Console.WriteLine("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = Array (size, min, max);
ShowArray (array);
Console.WriteLine();

int result = Sum (array);
Console.WriteLine($"Sum of elements with uneven index: {result}.");

// Программа работает.


// Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

int[] Array (int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray (int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

int MaxMin (int[] array, int size){
    int result = 0;
    int max = 0;
    int min = array[size-1];
    for (int i = 0; i < array.Length; i++){
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    result = max - min;
    return result;
}

Console.WriteLine("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = Array (size, min, max);
ShowArray (array);
Console.WriteLine();

int res = MaxMin (array, size);
Console.WriteLine($"Difference between max and min elements is {res}.");

// Программа работает.


// Задача * (семинар 5).
// Найдите произведение пар чисел в одномерном массиве. Пара - первый и последний элемент,
// второй и предпоследний элемент и т.д. Результат записать в новом массиве.

int[] CreateRandomArray (int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray (int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

void ProdPair (int[] array, int size){
    int n = 1;
    for (int i = 0; i < size/2; i++){
        array[i] *= array[size-n];
        n++;
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size % 2 == 0) {
    Console.WriteLine("Input min: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input max: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] array = CreateRandomArray (size, min, max);
    ShowArray (array);
    Console.WriteLine();
    ProdPair (array, size);
}
else Console.WriteLine("Укажите четный размер массива");


