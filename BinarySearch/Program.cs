using System.Reflection;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PruckiSLuk([5, 6, 10, 13, 14, 18, 30, 34, 35, 37, 40, 44, 64, 79, 84, 86, 95, 96, 98, 99], 10);

            static int PruckiSLuk(int[] arr, int value)
            {
                int arrayBegining = 0;
                int arrayEnding = arr.Length - 1;
                int middleOfArray = (arrayBegining + arrayEnding) / 2;


                while (arr[middleOfArray] != value && arrayBegining <= arrayEnding)
                {
                    Console.WriteLine($"{arrayBegining}, {middleOfArray}, {arrayEnding}");
                    if (value < arr[middleOfArray])
                    {
                        arrayEnding = middleOfArray - 1;
                    }
                    else if (value > arr[middleOfArray])
                    {
                        arrayBegining = middleOfArray + 1;
                    }

                    middleOfArray = (arrayBegining + arrayEnding) / 2;
                }

                Console.WriteLine($"{arrayBegining}, {middleOfArray}, {arrayEnding}");

                if (arr[middleOfArray] == value)
                {
                    Console.WriteLine(middleOfArray);
                    return middleOfArray;
                }

                Console.WriteLine(-1);
                return -1;
            }
        }

        //BinarySearch([1, 2, 3, 4, 5],2) // 1
        //BinarySearch([1, 2, 3, 4, 5],3) // 2
        //BinarySearch([1, 2, 3, 4, 5],5) // 4
        //BinarySearch([1, 2, 3, 4, 5],6) // -1
        //BinarySearch([
        //  5, 6, 10, 13, 14, 18, 30, 34, 35, 37,
        //  40, 44, 64, 79, 84, 86, 95, 96, 98, 99
        //], 10) // 2
        //BinarySearch([
        //  5, 6, 10, 13, 14, 18, 30, 34, 35, 37,
        //  40, 44, 64, 79, 84, 86, 95, 96, 98, 99
        //], 95) // 16
        //BinarySearch([
        //  5, 6, 10, 13, 14, 18, 30, 34, 35, 37,
        //  40, 44, 64, 79, 84, 86, 95, 96, 98, 99
        //], 100) // -1
    }
}
