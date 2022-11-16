namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Ilk ededi daxil edin:");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin:");
            num2 = Convert.ToInt32(Console.ReadLine()); 

            for (int i = num1; i < num2; i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}