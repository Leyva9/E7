internal class Program
{
    /*int day = 0;
        int month = 0;
        string year;
        int a;
        int b;
        int c;
        System.Console.WriteLine("Escribe su primer numero entero: ");
        a = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Escribe su segundo numero entero: ");
        b = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Escribe su tercer numero entero: ");
        c = Convert.ToInt32(Console.ReadLine());
        if(a < 12 && b<30 && (c>0 && c<100))
        {
            month = a;
            day = b;
            year = Convert.ToString(c);
            if(c < 10)
            {
                year.Insert(0,"0");
            }
            System.Console.WriteLine("{0}/{1}/{2}", day,month,year);
        }
        if(b < 12 || c<30 && (a>0 && a<100))
        {
            month = b;
            day = c;
            year = Convert.ToString(a);
            if(a < 10)
            {
                year.Insert(0,"0");
            }
            System.Console.WriteLine("{0}/{1}/{2}", day,month,year);
        }
        if(c < 12 || a<30 && (b>0 && b<100))
        {
            month = c;
            day = a;
            year = Convert.ToString(b);
            if(b < 10)
            {
                year.Insert(0,"0");
            }
            System.Console.WriteLine("{0}/{1}/{2}", day,month,year);
        }
        else
        {
            System.Console.WriteLine("No es posible crear una fecha");
        }*/
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