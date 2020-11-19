using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaalTafels
{
    class Program
    {
        static void Main(string[] args)
        {//declarations
            byte product, getal;
            string tafellijn;

            //INPUT
            //Vraag een getal
            Console.WriteLine();
            Console.Write("Geef een getal in tussen 1 en 10 ");
            Console.ReadLine();


            //processing + output
            // HERHAAL factor VAN TOT EN MET 10 STAPGROOTTE 1
            for (int factor = 1; factor <= 10; factor++)
            {
                // Bereken product( = factor x gegeven getal)
                product = (byte)(factor * (byte)getal);

                // Bereken tafelLijn("{factor} x 3 = {product}")
                tafellijn = $"{factor} * getal = {product}";

                // Toon tafelLijn
                Console.WriteLine();
            }


            // Wachten
            Console.Write("Druk op Enter om af te sluiten ...");
            Console.ReadLine();
        }
    }
}
