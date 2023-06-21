/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

/*
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int TwoDigitNumber(int num)
{
    num /= 10;
    num %= 10;
    return num;
}

int number = InputNum("Введите трехзначное число: ");
int result = TwoDigitNumber(number);
Console.WriteLine($"Вторая цифра числа: {result}");
*/


/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int ThreeDigitNumber(int num)
{
    num /= 100;
    num %= 10;
    return num;
}

int number = InputNum("Введите целое число: ");
int result = ThreeDigitNumber(number);
if (result != 0)
    Console.WriteLine($"Третья цифра числа: {result}");
else
    Console.WriteLine("Третьей цифры в числе нет");
*/



/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

Решение 10 и 13 задачи должно быть выполнено без использования свойств строк
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}



int num_day = InputNum("Введите номер дня недели: ");
if (num_day == 6 || num_day == 7)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");

