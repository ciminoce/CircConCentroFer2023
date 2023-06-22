using CircConCentroFer2023.Entidades;
using System;

namespace CircConCentroFer2023.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese el valor del radio de la circunferencia:");
                var radio = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la coord X del centro:");
                var x = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la coord Y del centro:");
                var y = int.Parse(Console.ReadLine());
                Punto p = new Punto(x, y);
                Circunferencia c = new Circunferencia(radio, p);
                //if (c.Validar())
                //{
                //    Console.WriteLine(c.ToString());
                //    Console.WriteLine(c.MostrarInfo());

                //    Console.Write("Ingrese la coord X del centro:");
                //    var xOtro = int.Parse(Console.ReadLine());
                //    Console.Write("Ingrese la coord Y del centro:");
                //    var yOtro = int.Parse(Console.ReadLine());
                //    Punto pOtro = new Punto(xOtro, yOtro);
                //    if (c.PuntoPerteneceACircunferencia(pOtro))
                //    {
                //        Console.WriteLine($"{pOtro.ToString()} pertenece a {c.ToString()}");
                //    }
                //    else
                //    {
                //        Console.WriteLine($"{pOtro.ToString()} no pertenece a {c.ToString()}");

                //    }

                //}
                //else
                //{
                //    Console.WriteLine("Circ no válida... Chequear el valor del radio");
                //}

                Console.WriteLine(c.ToString());
                Console.WriteLine(c.MostrarInfo());

                Console.Write("Ingrese la coord X del centro:");
                var xOtro = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la coord Y del centro:");
                var yOtro = int.Parse(Console.ReadLine());
                Punto pOtro = new Punto(xOtro, yOtro);
                if (c.PuntoPerteneceACircunferencia(pOtro))
                {
                    Console.WriteLine($"{pOtro.ToString()} pertenece a {c.ToString()}");
                }
                else
                {
                    Console.WriteLine($"{pOtro.ToString()} no pertenece a {c.ToString()}");

                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            //var c2=new Circunferencia(radio,new Punto(x, y));
            Console.ReadLine();
        }
    }
}
