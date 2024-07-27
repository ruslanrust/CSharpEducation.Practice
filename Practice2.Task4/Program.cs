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
            
            Console.WriteLine("Или так");

            {
                int spacesCount;
                int symCount = 1;

                for (int i = 1; i <= height; i += 1)
                {
                    spacesCount =  height - i;
                    for (int j = 0; j < spacesCount; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 0; k < symCount; k++)
                    {
                        Console.Write(sym);
                    }

                    symCount += 1;
                    Console.Write("\n");

                }
            }



        }
    }
}
