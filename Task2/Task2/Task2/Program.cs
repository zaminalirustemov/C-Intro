using System.Globalization;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Code Academy";
            word = word.Replace(" ", string.Empty);
            word = word.Replace("C", "c");
            word = word.Replace("A", "a");
            while (word.Length > 0)
            {
                Console.Write(word[0] + " = ");
                int count = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[0] == word[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                word = word.Replace(word[0].ToString(), string.Empty);
            }
        }
    }
}