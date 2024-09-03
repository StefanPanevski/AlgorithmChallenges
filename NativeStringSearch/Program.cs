namespace NativeStringSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringSearch("lorie Loled", "lol");

            static void StringSearch(string longString, string shortString)
            {
                int matches = 0;
                longString = longString.ToLower();
                shortString = shortString.ToLower();

                for (int i = 0; i < longString.Length; i++)
                {
                    for (int j = 0; j < shortString.Length; j++)
                    {
                       if (shortString[j]!= longString[i+j]) break;
                       if (j == shortString.Length-1) matches++;
                    }
                }

                Console.WriteLine(matches);
            }
        }
    }
}
