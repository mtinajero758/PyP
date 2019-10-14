using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoYPlaca
{
    class Program
    {
        static void Main(string[] args)
        {
            string cond;
            do {
                string fc;
                string placa;
                Console.Write("Ingrese fecha a verificar pico y placa (AAAA,MM,DD)...");
                fc = Console.ReadLine();
                string[] fecha = fc.Split(new char[] { ' ', ',','.','/','-' });
                DateTime dt = new DateTime(Convert.ToInt32( fecha[0]),Convert.ToInt32( fecha[1]),Convert.ToInt32( fecha[2]));

                Console.Write("Ingrese la placa del vehículo...");
                placa = Console.ReadLine();

                Console.WriteLine("El dia ingresado es " + dt.DayOfWeek);

                switch (dt.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        Console.WriteLine("Todos los vehículos circulan ");
                        break;
                    case DayOfWeek.Saturday:
                        Console.WriteLine("Todos los vehículos circulan");
                        break;
                    case DayOfWeek.Monday:
                        if (placa.EndsWith("1") || placa.EndsWith("2"))
                        {
                            Console.WriteLine("El vehículo con placa {0} NO puede circular", placa);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("El vehículo con placa {0} SI puede circular", placa);
                        }
                        break;
                    case DayOfWeek.Tuesday:
                        if (placa.EndsWith("3") || placa.EndsWith("4"))
                        {
                            Console.WriteLine("El vehículo con placa {0} NO puede circular", placa);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("El vehículo con placa {0} SI puede circular", placa);
                        }
                        break;
                    case DayOfWeek.Wednesday:
                        if (placa.EndsWith("5") || placa.EndsWith("6"))
                        {
                            Console.WriteLine("El vehículo con placa {0} NO puede circular", placa);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("El vehículo con placa {0} SI puede circular", placa);
                        }
                        break;
                    case DayOfWeek.Thursday:
                        if (placa.EndsWith("7") || placa.EndsWith("8"))
                        {
                            Console.WriteLine("El vehículo con placa {0} NO puede circular", placa);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("El vehículo con placa {0} SI puede circular", placa);
                        }
                        break;

                    case DayOfWeek.Friday:
                        if (placa.EndsWith("9") || placa.EndsWith("0"))
                        {
                            Console.WriteLine("El vehículo con placa {0} NO puede circular", placa);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("El vehículo con placa {0} SI puede circular", placa);
                        }
                        break;
                }
                Console.Write("Otra verificación (s/n)... ");
                cond = Console.ReadLine();
            }
            while (cond == "s");
        }
        
    }
    
}
