namespace NativeStringSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A method which solves the problem of finding how many times a string is contained within a larger string. The method accepts the longer string and then the shorter string that we want to find
            //if it is conatined (and if yes - how many times) within the longer string.
            StringSearch("lorie Loled", "lol");
            StringSearch("olelele malelelelei", "le");

            static void StringSearch(string longString, string shortString)
            {
                int matches = 0;
                longString = longString.ToLower();
                shortString = shortString.ToLower();

                for (int i = 0; i < longString.Length; i++)
                {
                    for (int j = 0; j < shortString.Length; j++)
                    {
                        if (shortString[j] != longString[i + j]) break;
                        if (j == shortString.Length - 1) matches++;
                    }
                }

                Console.WriteLine($"There are {matches} match(es).");
            }
        }
    }
}
