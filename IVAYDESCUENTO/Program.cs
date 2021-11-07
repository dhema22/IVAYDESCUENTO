using System;
using System.Globalization;

namespace IVAYDESCUENTO
{
    class Program
    {
        static void Main()
        {
            DescuentoIVA();
        }

        public static void DescuentoIVA()
        {
            string importe;
            Console.Write("Ingrese el importe gastado:");
            importe = Console.ReadLine();
            if (IsNumber(importe))
            {
                double importeA = Convert.ToDouble(importe);
                if (importeA >= 5000)
                {
                    double descuento = importeA * 0.1;
                    double importecondescuento = importeA * 0.9;
                    double importesiniva = importecondescuento / 1.21;
                    double importeiva = importecondescuento * 0.21;
                    Console.WriteLine("el importe del descuento es de {0}, el total a pagar es de {1}, el importe sin iva es de {2} y el total del iva es {3}.", descuento, importecondescuento, importesiniva, importeiva);
                }
                else
                {
                    double importesiniva = importeA / 1.21;
                    double importeiva = importeA * 0.21;
                    Console.WriteLine("el importe sin iva es {0} y el importe del iva es {1}", importesiniva, importeiva);
                }
            }
            else
            {
                Console.WriteLine("Ingrese valor numérico para el importe");
                Main();
            }
        }

        public static bool IsNumber(string importe) //es para asegurar que se introzca un número.
        {
            bool isnumber;
            CultureInfo culture = new CultureInfo("en-US");
            try
            {
                Convert.ToDouble(importe, culture);
                isnumber = true;
            }
            catch
            {
                isnumber = false;
            }
            return isnumber;
        }
    }
}
