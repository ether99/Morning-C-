/*
Task1:
int GetSum(int a)
{
int sum = 0;

for (int current = 1; current <= a; current++)  

    sum += current;
    return sum;

}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

    int result = GetSum(number);
    Console.WriteLine($"Sum of numbers from 1 to {number} is {result}");
*/

// Task1: Напишите программу, которая принимает на вход число и выдает количество 
//        цифр в числе.

    /*int Digits(int num)
    {
        int digits = 0;
        if (num == 0) digits = 1;
        while (num != 0)
        {
            num /= 10;
            digits++;
        }

        return digits;
    }

        Console.Write("Input your number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int dig = Digits(number);

        Console.WriteLine($"There are {dig} digits in {number}");
 */




// Task3: Напишите программу которая принимает на вход число N и выдает произведение
//        чисел от 1 до N;
/*
int Factorial(int num)
{
    int result = 1;
    for (int current = 1; current <= 0; current++)
    {
        result *= current;
    }

        return result;
}
    Console.Write("Enter your number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int result = Factorial(number);
    Console.WriteLine($"Factorial of number {number} is {result}");
*/
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++) 
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}
    void ShowArray(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        
            Console.Write(array[i] + " ");
            Console.WriteLine();
      
    }
    Console.Write("Input quantity of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] newArray = CreateRandomArray(size, min, max);
    ShowArray(newArray);
    */