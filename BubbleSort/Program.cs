namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO: Implement a bubble sort algorithm here
            BubbleSort([25, 3, 100, 7, 4, 58, 18, 30, 5, 10, 2]);

            static int[] BubbleSort(int[] sortArray)
            {
                Console.WriteLine("Initial state of the array:");
                foreach (var item in sortArray)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();

                for (int i = sortArray.Length - 1; i > 0; i--)
                {
                    for (int j = 0; j < sortArray.Length - 1; j++)
                    {
                        if (sortArray[j] > sortArray[j + 1])
                        {
                            //swap values to sort the array
                            SwapValues(sortArray, j);
                        }

                        foreach (var item in sortArray)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("New outer loop iteration:");
                }

                Console.WriteLine("Sorted array:");
                foreach (var item in sortArray)
                {
                    Console.Write($"{item} ");
                }
                return sortArray;
            }

            static void SwapValues(int[] array, int n)
            {
                var temp = array[n];
                array[n] = array[n + 1];
                array[n + 1] = temp;
            }
        }
    }
}
