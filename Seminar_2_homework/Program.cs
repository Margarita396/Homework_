// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondNumber(){
    int number = new Random().Next(100, 1000);
    Console.WriteLine("Random number is " + number);
    int num2 = (number / 10) % 10;
    return num2;
}

Console.WriteLine("Second number is " + SecondNumber());

// Программа выполняется.


// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdNumber(int num){
    if (num < 100){
        Console.WriteLine("Нет третьей цифры");
    }
    else if (num > 99 && num < 999){
        int num3 = num % 10;
        Console.WriteLine(num3);
    }
    else{
        while(num > 999){
            num = num / 10;
        }
        int num3 = num % 10;
        Console.WriteLine(num3);
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

ThirdNumber(number);

// Программа вроде как работает.


// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Week(int num){
    if (num > 0 && num < 6){
        Console.WriteLine("Будний день");
    }
    else if (num == 6 || num == 7){
        Console.WriteLine("Выходной день");
    }
    else{
        Console.WriteLine("Некорректно введено число");
    }
} 

Console.WriteLine("Введите цифру дня недели:  ");
int day = Convert.ToInt32(Console.ReadLine());
Week(day);

// Программа выполняется.

