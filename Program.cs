internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Escriba el dia por favor: ");
        int a = Convert.ToInt16(Console.ReadLine()) + 32736;
        a = a - 32736;
        System.Console.WriteLine("Escriba el mes por favor: ");
        int b = Convert.ToInt16(Console.ReadLine()) + 32755;
        b = b - 32755;
        System.Console.WriteLine("Escriba el año por favor: ");
        int c = Convert.ToInt16(Console.ReadLine()) + 30744;
        c = c - 30744;
        System.Console.WriteLine("{0}/{1}/{2}",a.ToString().PadLeft(2, '0'), b.ToString().PadLeft(2, '0'), c.ToString().PadLeft(2, '0'));
    }
}