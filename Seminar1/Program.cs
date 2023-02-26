
// double bigNum = 14.345;
// bool isEven = true;
// string word = "flower";
// char symbol = '$';


// int num1 = -12;
// int num2 = 6;

// Console.Write("My number are  " + (num1 +   num2) +  " and it is good");
// Console.WriteLine($"My number are  {num1} and {num2}  and it is good");

// Console.Write("Input an integer number:   ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("You number is " + num);


// Seminar 1. 
// Task 1. Напишите программу, которая на вход принимает два числа и 
//         проверяет является ли первое число квадратом второго.

  /*Console.Write("Input a first number: ");
  int num1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a second number: ");
  int num2 = Convert.ToInt32(Console.ReadLine());

  int quad2 = num1 * num2; 
  if(num1 == num2)

    Console.Write("Yes!");
  else
    Console.Write("No!");
 */

 // Task 2. Напишите программу, которая на вход принимает одно число (N),
 //         а на выходе показывает все целые числа в промежутке от -N до N.

//  Console.Write(" Input a positive number: ");
//   int num = Convert.ToInt32(Console.ReadLine());
//   int current = -num;

//   while(current <= num)
//   {
//       Console.Write(current + " ");
//       current ++;
//   }


    // 31542 / 10 = 3154
    // 31542 / 100 = 315
    // 31542 / 1000 = 31
    // 31542 / 10000 = 3

    //   31542 % 10 = 2
    //   31542 % 100 = 42
    //   31542 % 1000 = 542
    //   31542 % 10000 = 1542

    //   453216 -> 32


// HomeWork1
// Task1. Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) 

  Console.Write("The first number " + num1 + 
  " is greater than the second number " + num2);
else
  Console.Write("The second number " + num2 + 
  " is greater than the first number " +  num1);
  