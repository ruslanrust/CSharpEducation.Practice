namespace Practice2.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите зачение переменной a");
            double a = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
                return;
            }
            
            Console.WriteLine("Введите зачение переменной b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите зачение переменной f");
            double f = double.Parse(Console.ReadLine());

            double result = (a + b - f / a) + f * a * a - (a + b);
            Console.WriteLine(result);

        }
    }
}
