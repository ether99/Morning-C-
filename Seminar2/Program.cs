
// Task 1.
// int CutNumber(int num)
// {
//   int hundreds = num / 100;
//   int units = num % 10;
//   int result = hundreds * 10 + units;
//   return result;
// }

// int randNumber = new Random().Next(100,1000);
// int newNumber = CutNumber(randNumber);
// Console.WriteLine($"New version of {randNumber} is {newNumber}");

// Task 2.

// bool IsMultiplyedBest (int num, int div1, int div2)
// {
// return num % div1 == 0 && num % div2 == 0;
// }


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
