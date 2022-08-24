//Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Задача 2");

int number1;

Console.Write("Введите число 1: ");
number1 = Convert.ToInt32(Console.ReadLine());

int number2;

Console.Write("Введите число 2: ");
number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2){
    Console.WriteLine("max = " + number1);
}
else{
    Console.WriteLine("max = " + number2);
}

//Программа работает корректно.


//Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.WriteLine("Задача 4");

int num1;

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

int num2;

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

int num3;

Console.Write("Введите третье число: ");
num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("max = ");
Console.WriteLine(max);

//Программа работает.


//Задача 6: Напишите программу,которая на вхо принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

Console.WriteLine("Задача 6");

int num;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

if ((num % 2)==0){
    Console.WriteLine("Четное число");
}
else{
    Console.WriteLine("Нечетное число");
}

//Программа работает.


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.

Console.WriteLine("Задача 8");

int N;

Console.Write("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i <= N){
    if ((i % 2) == 0){
        Console.Write(i + " ");
        i++;
    }
    else{
        i++;
    }
}

//Программа работает.

