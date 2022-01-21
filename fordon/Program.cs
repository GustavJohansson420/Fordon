using System;

namespace fordon
{
    class Program
    {
        static void Main(string[] args)
        {
            Fordon f = new Fordon();
            f.Märke = "Volvo";
            f.Modell = "V70";
            f.Årsmodell = 2016;

            Console.WriteLine(f.Märke);
            Console.WriteLine(f.Modell);
            Console.WriteLine(f.Årsmodell);
        }
    }
}
