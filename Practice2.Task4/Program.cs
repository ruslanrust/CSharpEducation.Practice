namespace Practice2.Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sym = "*";

            Console.WriteLine("Введите высоту елочки");
            int height = int.Parse(Console.ReadLine());

            {
                string line = "";
                for (int i = 1; i <= height; i += 1)
                {
                    line = line + sym;
                    Console.WriteLine(line);
                }
            }


            {
                string line = "";
                int spacesCount;
                int symCount = 1;

                for (int i = 1; i <= height; i += 1)
                {
                
                    line = sym + line;
                    Console.WriteLine(line);
                }
            }



        }
    }
}
