namespace Practice2.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int meters = 5000;
                int metersInKilometer = 1000;
                int kilometers = meters / metersInKilometer;
            }

            {
                int kilometers = 2;
                int centimetersInKilometer = 100000;
                int centimeters = kilometers * centimetersInKilometer;
            }

            {
                double metersPerSecond = 5;
                double kilometersPerHourInMetersPerSecond = 3.6;
                double kilometersPerHour = metersPerSecond * kilometersPerHourInMetersPerSecond;
            }

            {
                double degrees = 25;
                double fahrenheit = (degrees * 9 / 5) + 32;
            }
        }
    }
}
