/* Seminar2
Task 1.
int CutNumber(int num)
{
  int hundreds = num / 100;
  int units = num % 10;
  int result = hundreds * 10 + units;
  return result;
}

int randNumber = new Random().Next(100,1000);
int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");

Task 2.

bool IsMultiplyedBest (int num, int div1, int div2)
{
return num % div1 == 0 && num % div2 == 0;
}


bool IsMultiplyed(int num, int div1, int div2)
{
  if (num % div1 == 0 && num % div2 == 0)
       //if (num % div1 * div2 == 0)
      return true; 
    else
      return false;
}

Console.Write("Input a number for checking: ");
    int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a first divider: ");
    int divider1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second divider: ");
    int divider2 = Convert.ToInt32(Console.ReadLine());
    bool result = IsMultiplyed(number, divider1, divider2); 
//Console.WriteLine(result);

if(result)
Console.WriteLine($"Your number {number} is divisible by the {divider1} and {divider2}");
else
Console.WriteLine($"Your number {number} is not divisible by the {divider1} and {divider2}");


//Homework 2

Task1: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

Decision:

Console.Write("Enter a three-digit number: ");
  int num = Convert.ToInt32(Console.ReadLine());

int SecondNumber(int num)
{
    int result = ((num / 10) % 10);
    return result;
}
    int secondNum = SecondNumber(num);
    Console.WriteLine("The second digit of this number"  + secondNum);



Task2: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
 что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

//Decision:

    Console.Write("Enter a positive number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int ThirdDigit(int num)
    {
      int result = -1;
      if (num >= 100)
      {
        while (num > 999)
        {
          num = num / 10;
        }
        result = num % 10;
      }
      return result;
    }
    
    bool check(int num)
    {
      if (num < 100)
      return false;
      else return true;
    }
      if (check(num) != true)
    Console.WriteLine("There is no third digit.");
      else
    Console.WriteLine($"Third digit is {ThirdDigit(num)}");
  */


// Task3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


// Decision:


int dayWeek = ReadInt("Enter a number from 1 to 7: ");
Console.WriteLine(Weekend(dayWeek));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string Weekend(int num)
{
    if (num > 0 && num < 8)
 {
    if (num == 7 || num == 6)
    {
      Console.Write("Number " + num + " - Weekend");
    }
    else
   {
      Console.Write("Number " + num + " - Working");
    }
    }
    else
    {
        Console.Write("The number is not in the range from 1 to 7");
    }
    return " day.";
}




