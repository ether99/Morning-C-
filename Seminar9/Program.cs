//  void ShowNums (int num)
//  {  
//     Console.Write (num + " ");
//     if (num > 1) ShowNums (num - 1);
//     Console.Write(num + " ");
//  }
//     ShowNums (5);

int SumOfDigits(int num)
{
if (num / 10 != 0) return SumofDigits (num / 10) + Math. Abs (num % 10);
return Math.Abs(num);
}
Console.WriteLine (SumofDigits (- 1234)) ;

// f(1234) -> f(123) + 4
// f(123) -> f(12) + 3
// f(12) -> f(1) + 2
// f(1) -> 1
// f (12) -> 1 + 2 = 3
// f(123) -> 3 + 3 = 6
// (1234) -> 6 + 4 = 10

void ShowNums (int n, int m)
{
  if(n > m) ShowNums(n, m + 1);
  if(n < m) ShowNums(n, m - 1);
    Console.Write(m + " ");
}
  ShowNums(8, 5);