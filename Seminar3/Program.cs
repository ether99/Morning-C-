// void ShowRange(int quad)
// {
//     if(quad == 1) Console.WriteLine("x > 0 and y > 0");
//     else if (quad == 2) Console.WriteLine(" x < 0 and y > 0");
//     else if (quad == 3) Console.WriteLine(" x < o and y < 0");
//     else if (quad == 4) Console.WriteLine(" x > 0 and y < 0");
//     else Console.WriteLine(" Uncorrect input!");
// }
//   Console.Write("Input a number of quadrant: ");
//   int quadrant = Convert.ToInt32(Console.ReadLine());
//   ShowRange(quadrant); 


//  Task 1. По координатам точки определить номер четверти в координатной плоскости.

  // int getQuarter(int x, int y){
  
  //   if (x > 0 && y >0)
  //     return 1;
  //   if (x < 0 && y > 0)
  //     return 2;
  //   if (x < 0 && y < 0)
  //     return 3;
  //   if (x > 0 && y < 0)
  //     return 4;

  //     return -1;
  // }
  //   Console.Write("Введите координату x: ");
  //   int x = Convert.ToInt32(Console.ReadLine());
  //   Console.Write("Введите координату y: ");
  //   int y = Convert.ToInt32(Console.ReadLine());

  //   int quarter = getQuarter(x, y);
  //     if (quarter > 0)
  //         Console.WriteLine($"point is in {quarter} quarter");
  //         else
  //         Console.WriteLine($"point is not quarters");


    // Task 2. По координатам двух точек найти расстояние между ними.

    // double getDistance(double xa, double ya, double xb, double yb) {
    //   return Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));
    // }
    //   Console.Write("Введите координату X первой точки: ");
    //   double xa = Convert.ToDouble(Console.ReadLine());
    //   Console.Write("Введите координату Y первoй точки: ");
    //   double ya = Convert.ToDouble(Console.ReadLine());

    //   Console.Write("Введите координату X второй точки: ");
    //   double xb = Convert.ToDouble(Console.ReadLine());
    //   Console.Write("Введите координату Y второй точки: ");
    //   double yb = Convert.ToDouble(Console.ReadLine());

    //   Console.WriteLine("Расстояние мeжду точками: " + Math.Round(getDistance(xa, ya,xb, yb), 2));
      

  // Task 3. Таблица чисел от 1 до N.

    // void squareTable(int n) {
    // int currentNumber = 1;
    //  while(currentNumber <= n) {
    //     Console.WriteLine(currentNumber + " - " + (currentNumber * currentNumber));
    // currentNumber++;
    //   }
    // }
    //     Console.Write("Введите число: ");
    //     int n = Convert.ToInt32(Console.ReadLine());
    //       if (n > 0)
    //       squareTable(n);
    //       else
    //       Console.Write("Введите число больше 0");


// Homework 3:
// Task 1: 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

  // Decision:
  // Console.WriteLine("Input a number. ");
  //   string number = Console.ReadLine();
  //   int ar = number.Length; 
  //     if(ar == 5) {
  //       if (number[0] == number[4] && number[1] == number[3]) {
  //           Console.WriteLine($"{number} is a palindrome.");
  //       }
  //       else {
  //         Console.WriteLine($"{number} is not a palindrome. ");
  //       }
  //     }
  //     else {
  //       Console.WriteLine($"The number: {number} is not five - digit.");
  //     }

// Task 2:
// Напишите программу, которая принимает на вход координаты двух точек и находит 
//  расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Decision:
/*
    int x1 = ReadInt("Enter the coordinate X the first point: ");
    int y1 = ReadInt("Enter the coordinate Y the first point:  ");
    int z1 = ReadInt("Enter the coordinate Z the first point:  ");
    int x2 = ReadInt("Enter the coordinate X the second point: : ");
    int y2 = ReadInt("Enter the coordinate Y the second point: : ");
    int z2 = ReadInt("Enter the coordinate Z the second point: : ");

    int A = x2 - x1;
    int B = y2 - y1;
    int C = z1 - z2;

      double length = Math.Sqrt(A * A + B * B + C * C);
      
      Console.WriteLine($"distance {length}");

      int ReadInt(string message)
      {
          Console.Write(message);
          return Convert.ToInt32(Console.ReadLine());
      }

*/

// Task 3:
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Decision:
/*
 void squareTable(int n) {
    int currentNumber = 1;
     while(currentNumber <= n) {
        Console.WriteLine(currentNumber + " - " + (currentNumber * currentNumber * currentNumber));
    currentNumber++;
      }
    }
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
          if (n > 0)
          squareTable(n);
          else
          Console.Write("Enter a positive number.");
*/

   