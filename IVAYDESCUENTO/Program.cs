using System;
using System.Globalization;

namespace IVAYDESCUENTO
{
    class Program
    {
        static void Main()
        {
            CalcularIVA();
        }
        public static void CalcularIVA()
        {
            string importe;
            Console.Write("Ingrese el importe gastado:");
            importe = Console.ReadLine();
            if (IsNumber(importe))
            {
                double importeingresado = Convert.ToDouble(importe);
                if (importeingresado >= 5000)
                {
                    importeingresado=CalcularDescuento(importeingresado);
                }
                double importesiniva = importeingresado / 1.21;
                Console.WriteLine("El importe sin iva es {0}",importesiniva); 
            }
            else
            {
                Console.WriteLine("Ingrese valor numérico para el importe despues de descuento es {1}");
                Main();
            }
        }

        public static double CalcularDescuento(double descuentoaplicado)
        {
            double importedescuento = descuentoaplicado * 0.9;
            double totaldescontado = descuentoaplicado * 0.1;
            Console.WriteLine("importe despues de descuento: {0} y el importe descontado es: {1}",importedescuento,totaldescontado);
            return importedescuento;
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
