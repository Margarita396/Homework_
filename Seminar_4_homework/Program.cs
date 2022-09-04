// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void Deg (int a, int b){
    int result = 1;
    for ( int i = 1; i <= b; i++){
        result *= a;
    }
    Console.WriteLine($"Результат возведения числа {a} в степень {b} равен {result}");
}

Console.WriteLine("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
Deg(numA, numB);

// Программа работает корректно.


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void Sum (int number){
    int sum = 0;
    for (int i = number; i != 0; i /= 10){
        sum += (i % 10);
    }
    Console.WriteLine($"Сумма цифр числа {number} равна {sum}");
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Sum (num);

// Программа работает.


// Задача 29: Напишите программу, которая задаёт массив из произвольного числа элементов и выводит их на экран.

int Size (int min, int max){
    int size = new Random().Next(min, max);
    Console.WriteLine();
    Console.WriteLine("Количество элементов массива: " + size);
    return size;
}

void CreateNewArray (int size, int min, int max){ 
    Console.Write("[ ");
    int [] array = new int [size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max);
        Console.Write(array [i] + " ");
    }
    Console.Write("]");
}

Console.Write("Введите значение минимального размера массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение максимального размера массива: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите минимальное значение элементов массива: ");
int num_min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int num_max = Convert.ToInt32(Console.ReadLine());

CreateNewArray (Size (min,max), num_min, num_max);

// Не уверена, что это рациональное решение, но оно работает.

