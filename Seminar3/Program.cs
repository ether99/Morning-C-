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
  //         Console.WriteLine($"point is in (quarter) quarter");
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
