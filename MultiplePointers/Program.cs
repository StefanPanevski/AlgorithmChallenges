namespace MultiplePointers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Implement a function called countUniqueValues, which accepts a sorted array, and counts the unique values in the array. There can be negative numbers in the array,
             * but it will always be sorted.
             * countUniqueValues([1,1,1,1,1,2]) // 2
             * countUniqueValues([1,2,3,4,4,4,7,7,12,12,13]) // 7
             * countUniqueValues([]) // 0
             * countUniqueValues([-2,-1,-1,0,1]) // 4
             * Time Complexity - O(n)
             * 
             * Space Complexity - O(n
             * 
             * 
             * Bonus
             * 
             * You must do this with constant or O(1) space and O(n) time.*/

            string input = Console.ReadLine();

            string[] inputString = input.Split(',');

            int[] numArray = inputString.Select(int.Parse).ToArray();

            CountUniqueValues(numArray);


            static void CountUniqueValues(int[] arr)
            {
                if (arr.Length == 0 ) return;

                int x = 0;
                int y = 1;
                List<int> uniqueValue = new List<int>();

                uniqueValue.Add(arr[x]);

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr.Length == y)
                    {
                        break;
                    }
                    if (arr[x] == arr[y] && y < arr.Length)
                    {
                        y++;
                    }
                    else if (arr[x] != arr[y])
                    {
                        uniqueValue.Add(arr[y]);
                        x = y;
                        y++;
                    }
                }

                foreach (int value in uniqueValue)
                {
                    Console.Write($"{value} ");
                }

                Console.WriteLine();
                Console.WriteLine(uniqueValue.Count);
            }
        }
    }
}
