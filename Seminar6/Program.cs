int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[ size];
    for (int i = 0; i < size; i++)
    array[i] = new Random () . Next (minValue, maxValue + 1) ;
      return array;
}

  void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
}

void ReserveArray(int [] array)
{
  for(int i = 0, j = array.Length - 1; i < j; i++, j--)
  {
    int temp = array[i];
    array[i] = array [j];
    array[j] = temp;
  }
}
  // int GetNegativeSum(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)

//     if (array[i] < 0)
//        sum += array[i];

//     return sum;
// }

Console.Write("Input a quantity of elements: ");
int size = Convert. ToInt32(Console. ReadLine ( ));
Console.Write("Input a min possible value: ");
int min = Convert. ToInt32(Console. ReadLine ( ));
Console.Write("Input a max possible value: ");
int max = Convert. ToInt32(Console. ReadLine ()) ;

int[] newArray = CreateRandomArray (size, min, max);
ShowArray (newArray);
ReserveArray(newArray);
ShowArray(newArray);

// int result = GetNegativeSum (newArray);
// Console.WriteLine("Sum of negatives is " + result);
