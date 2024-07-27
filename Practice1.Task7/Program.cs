internal class Program
{
    private static void Main(string[] args)
    {
        double leg1 = 3;
        double leg2 = 5;
        double hypotenuse = 4;

        double unknownHypotenuse = Math.Sqrt(leg1 * leg1 + leg2 * leg2);
        double unknownLeg = Math.Sqrt(hypotenuse * hypotenuse - leg1 * leg1);

        Console.WriteLine($"При двух известных катетах 3 и 5, гипотенуза равна {unknownHypotenuse}");
        Console.WriteLine($"При известном катете 3 и гипотенузе 4, второй катет равеен {unknownLeg}");

    }
}