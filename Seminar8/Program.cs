  //  Seminar 8

void ChangeRows (int[,] array, int row1, int row2)
{
if (row1 >= 0 && row1 < array. GetLength (0) && 
   row2 >= 0 && row2 < array. GetLength(0) && 
   row1 != row2)
   {
for(int j = 0; j < array.GetLength (1); j++)
{
int temp = array[row1, j];
array[row1, j] = array[row2, j];
array[row2, j] = temp;
      }
   }
}

// int[,] newArray = CreateRandom2dArray ();
// Show2dArray (newArray);
// Console.Write("Input a first row for changing: ");
// int r1 = Convert. ToInt32(Console. ReadLine ());
// Console.Write("Input a second row for changing: ");
// int r2 = Convert. ToInt32(Console. ReadLine ());

// ChangeRows (newArray, r1, r2);
// Show2dArray (newArray);