namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(j);
                j += 1;
            }

            int k = 0;
            do
            {
                Console.WriteLine(k);
                k += 1;
            } while (k < 5);

            string result1 = "";

            for (int i = 0; i < 3; i++)
            {
                string str = Console.ReadLine();
                result1 = $"{result1}{str} ";
            }
            Console.WriteLine(result1);

            string result2 = "";
            int f = 0;
            while (f < 3)
            {
                string str = Console.ReadLine();
                result2 = $"{result2}{str} ";
                f += 1;
            }
            Console.WriteLine(result2);

            string result3 = "";
            int l = 0;
            do
            {
                string str = Console.ReadLine();
                result3 = $"{result3}{str} ";
                l += 1;
            } while (l < 3);
            Console.WriteLine(result3);


        }
    }
}
