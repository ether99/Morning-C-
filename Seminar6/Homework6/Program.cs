// Homework 6:
// Task 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//         0, 7, 8, -2, -2 -> 2
//         1, -7, 567, 89, 223-> 3
/*
Console.Write("Enter the numbers separated by commas: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"The number of values is greater than 0 = {sum}");


int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}
*/
// Task 2:  Напишите программу, которая найдёт точку пересечения двух прямых, 
//          заданных уравнениями y = k1 * x + b1 y = k2 * x + b2 значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.WriteLine("Enter a value b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a number k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a value b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a number k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Two straight lines will intersect at a point eith coordinates X: {x}, Y: {y}");
*/