// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Задача 19");

void Paly(int num){
    int left = num / 1000;
    int ed = num % 10;
    int dec = (num % 100) / 10;
    int right = ed * 10 + dec;

    if (left == right) Console.WriteLine("Число является палиндромом");
    else Console.WriteLine("Число не палиндром");
}

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10000 || number > 99999){
    Console.WriteLine("Ввод не соответствует условию");
}
else{
    Paly(number);
}

// Программа работает.


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine();
Console.WriteLine("Задача 21");

double Distance (int x1, int y1, int z1, int x2, int y2, int z2){
    int x = (x2 - x1)*(x2 - x1);
    int y = (y2 - y1)*(y2 - y1);
    int z = (z2 - z1)*(z2 - z1);
    int sum = x + y + z;
    double S = Math.Sqrt(sum);
    return S;
}

Console.Write("Введите координату Х первой точки: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Х второй точки: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
int zb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Расстояние между точками: " + Distance (xa, ya, za, xb, yb, zb));

// Программа работает.


// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine();
Console.WriteLine("Задача 23");

void Cube (int number){
    int index = 1;
    while (index <= number){
        Console.Write(index*index*index + ", ");
        index++; 
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 1) Console.WriteLine("Некорректный ввод");
else Cube(num);

// Программа работает.


