// Запрос данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}

// Вывод результата
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}



// Задача 64:
// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

string NumMN(int numM, int numN)
{
    // Точка остановки
    if (numM >= numN)
    {
        return numN.ToString();
    }
    else
    {
        // Рекурентный вызов метода
        return numM + ", " + NumMN(numM + 1, numN);
    }
}

int numM = ReadData("Введите число М: ");
int numN = ReadData("Введите число N: ");

string result = (numM < numN) ? (NumMN(numM, numN)) : (NumMN(numN, numM));

PrintData("Натуральные числа в промежутке от " + numM + " до " + numN + ": ", result);



// // Задача 66:
// // Задайте значения M и N. Напишите программу, которая
// // найдёт сумму натуральных элементов в промежутке от M до N.

int SumMN(int numM, int numN)
{
    // Точка остановки
    if (numM >= numN)
    {
        return numN;
    }
    else
    {
        // Рекурентный вызов метода
        return numM + SumMN(numM + 1, numN);
    }
}

int numberM = ReadData("Введите число М: ");
int numberN = ReadData("Введите число N: ");

int sum = 0;
if (numberM < numberN)
{
    sum = SumMN(numberM, numberN);
}
else
{
    sum = SumMN(numberN, numberM);
}

PrintData("Сумма чисел в промежутке от " + numberM + " до " + numberN + " равна: ", sum.ToString());



// Задача 68:
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int MethodAkkermana(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return MethodAkkermana(m - 1, 1);
    }
    else
    {
        return MethodAkkermana(m - 1, MethodAkkermana(m, n - 1));
    }
}

int m = ReadData("Введите число m: ");
int n = ReadData("Введите число n: ");
int res = MethodAkkermana(m, n);
PrintData("Результат вычисления функции Аккермана для чисел " + m + " и " + n + ": ", res.ToString());


