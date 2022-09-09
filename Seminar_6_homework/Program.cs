// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Задача 41");

int[] Numbers (int m){
    int[] array = new int[m];
    for (int i = 0; i < m; i++){
        Console.WriteLine("Введите число: ");  
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowNumbers (int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]}  ");
    }
}

int PositiveNumbers (int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] numbers = Numbers (m);
ShowNumbers (numbers);
Console.WriteLine();

int result = PositiveNumbers (numbers);
Console.WriteLine($"Вы ввели {result} чисел больше 0.");

// Программа работает.


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Задача 43");

void CrossPoint (double b1, double k1, double b2, double k2){
    double x = (b2-b1)/(k1-k2);
    double y = (k1 * x) + b1;
    Console.WriteLine($"Точка пересечения прямых имеет координаты ({x};{y}).");
}

Console.WriteLine("Две прямые заданны уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите b1:  ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1:  ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2:  ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2:  ");
double k2 = Convert.ToInt32(Console.ReadLine());

CrossPoint (b1, k1, b2, k2);

// Программа работает.


