  //  Seminar 8

/*void ChangeRows (int[,] array, int row1, int row2)
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

int[,] newArray = CreateRandom2dArray ();
Show2dArray (newArray);
Console.Write("Input a first row for changing: ");
int r1 = Convert. ToInt32(Console. ReadLine ());
Console.Write("Input a second row for changing: ");
int r2 = Convert. ToInt32(Console. ReadLine ());

ChangeRows (newArray, r1, r2);
Show2dArray (newArray);
*/
// 1 2 3
// 4 5 6
// 7 8 9

// 1 4 7
// 2 5 8
// 3 6 9


//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// void TransposeArray (int [,] array) {
//       if (array. GetLength(0) == array. GetLength (1)) {
//          for (int i = 0; i < array. GetLength (0) - 1; i++) 
//             for (int j= i+ 1; j < array. GetLength (1); j++) {
//       int tmp = array[i, j];
//       array[j,i] = tmp;
// }
//       } else
//          Console.WriteLine ("Unable to transpose array");
// }
//    int[,] newArray = CreateRandom2dArray();
//       Show2dArray(newArray) ;
//       TransposeArray(newArray);
//       Show2dArrav(newArrav):




//    int[] FindMinPosition (int [,] array) {
//       int [] result = new int[2];
//       for(int i = 0; i < array. GetLength (0); i++)
//          for(int j = 0; j < array. GetLength (1); j++)
//          if (array[i, j] < array[result[0], result[1]]) {
//       result [0] = i;
//       result [1] = j;
//          }
//          return result;
      
//  int[,] RemoveRowAndColumn(int[,] array, int row, int col) {
// int[,] result = new int [array. GetLength(0) - 1, array. GetLength (1) - 1];

//    for (int i = 0, newI = 0; i < array. GetLength (0) ; i++)
//       if (i != row) {
//    for(int j = 0, newJ = 0; j < array. GetLength (1); j++)
//       if (j != col) {
//       result[newI, newJ] = array[i, j];
//          newI++;
//       }

//    return result;
//  int[,] array = CreateRandom2dArray();
//    Show2dArray (array);
//       int[] minPosition = FindMinPosition(array);
//       int[,] newArray = RemoveRowAndColumn (array, minPosition[0], minPosition [1]);
//       Show2dArray (newArray);