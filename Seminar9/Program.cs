//  void ShowNums (int num)
//  {  
//     Console.Write (num + " ");
//     if (num > 1) ShowNums (num - 1);
//     Console.Write(num + " ");
//  }
//     ShowNums (5);

// int SumOfDigits(int num)
// {
// if (num / 10 != 0) return SumofDigits (num / 10) + Math. Abs (num % 10);
// return Math.Abs(num);
// }
// Console.WriteLine (SumofDigits (- 1234)) ;

// f(1234) -> f(123) + 4
// f(123) -> f(12) + 3
// f(12) -> f(1) + 2
// f(1) -> 1
// f (12) -> 1 + 2 = 3
// f(123) -> 3 + 3 = 6
// (1234) -> 6 + 4 = 10

// void ShowNums (int n, int m)
// {
//   if(n > m) ShowNums(n, m + 1);
//   if(n < m) ShowNums(n, m - 1);
//     Console.Write(m + " ");
// }
//   ShowNums(8, 5);


//   Homework9
/*
 Task 1: Задайте значения N. Напишите программу, которая выведет все натуральные числа 
         в промежутке от N до 1.
         N = 5. -> "5, 4, 3, 2, 1"
         N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"
 
 
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalToLow(number, count);


void NaturalToLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalToLow(n, count + 1);
        Console.Write(count + " ");
    }
}
*/
 
//  Task 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//          элементов в промежутке от M до N.
//          M = 1; N = 15 -> 120
//          M = 4; N = 8. -> 30
 
 /*
Console.Write("Enter a number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a number N: ");
int n = Convert.ToInt32(Console.ReadLine());

  SumFromMToN(m, n);
void SumFromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}

*/
//  Task 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
//          неотрицательных числа m и n.
//          m = 2, n = 3 -> A(m,n) = 9
//          m = 3, n = 2 -> A(m,n) = 29
 
 /*
Console.Write("Enter a number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a number N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);

void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
*/