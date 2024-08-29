namespace LinearSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = [9, 8, 7, 6, 5, 4, 3, 2, 1, 0];
            int num = 4;

            //LinearSearch(array, num);
            LinearSearch([9, 8, 7, 6, 5, 4, 3, 2, 1, 0], 10);

            static int LinearSearch(int[] arr, int number)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == number)
                    {
                        Console.WriteLine(i);
                        return i;
                    }
                }

                Console.WriteLine(-1);
                return -1;
            }
        }
    }
}
