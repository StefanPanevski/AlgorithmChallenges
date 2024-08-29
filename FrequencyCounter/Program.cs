using System.Security.Cryptography.X509Certificates;

namespace FrequencyCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"", "" true; "aaz", "zaa" false; "anagram","nagaram" true
            

            static bool ValidAnagram(string inputOne, string inputTwo)
            {

                if (inputOne.Length != inputTwo.Length)
                {
                    return false;
                }

                for (int i = 0; i < inputOne.Length; i++)
                {
                    char letter = inputOne[i];
                }

                for (int i = 0; i < inputTwo.Length; i++)
                {
                    char letter = inputTwo[i];

                }

                return true;
            }
        }
    }
}
