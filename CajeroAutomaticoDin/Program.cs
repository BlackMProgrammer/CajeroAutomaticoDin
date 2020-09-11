using System;
using System.Reflection.Metadata;

namespace CajeroAutomaticoDin
{
    class Program
    {
        static void Main(string[] args)
        {
            float cantidad;
            string cantidadval;
            int c100, c500, c1000,valcan;
            c100 = 0;
            c500 = 0;
            c1000 = 0;
            valcan = 0;
            Console.WriteLine("Bienvenido al Cajero ATM de que Banco desea retirar su dinero?:");
            Console.WriteLine("A.Banco ABC");
            Console.WriteLine("B.Otros Bancos");

            string banco = Console.ReadLine().ToLower();
            {
                if (banco == "a")
                {
                    Console.WriteLine("Digite la Cantidad a retirar:");
                    cantidadval = Console.ReadLine();
                    cantidad = float.Parse(cantidadval);
                    if (cantidad > 10000)
                    {
                        Console.WriteLine("El limite de la transaccion es de: RD$ 10,000");
                    }
                    else {
                        if (cantidad >= 1000)
                        {
                            c1000 = ((int)cantidad / 1000);
                            cantidad = cantidad - (c1000 * 1000);
                        }

                        if (cantidad >= 500)
                        {
                            c500 = ((int)cantidad / 500);
                            cantidad = cantidad - (c500 * 500);
                        }

                        if (cantidad >= 100)
                        {
                            c100 = ((int)cantidad / 100);
                            cantidad = cantidad - (c100 * 100);
                            valcan = ((int)cantidad);
                        }
                    }
                }
                else if (banco == "b")
                {
                    Console.WriteLine("Digite la Cantidad a retirar:");
                    cantidadval = Console.ReadLine();
                    cantidad = float.Parse(cantidadval);
                    if (cantidad >= 2000)
                    {
                        Console.WriteLine("Para retirar el monto de: RD$ {0} debe ser cliente del banco ABC");
                    }
                    else 
                    {
                        if (cantidad >= 1000)
                        {
                            c1000 = ((int)cantidad / 1000);
                            cantidad = cantidad - (c1000 * 1000);
                        }

                        if (cantidad >= 500)
                        {
                            c500 = ((int)cantidad / 500);
                            cantidad = cantidad - (c500 * 500);
                        }

                        if (cantidad >= 100)
                        {
                            c100 = ((int)cantidad / 100);
                            cantidad = cantidad - (c100 * 100);
                            valcan = ((int)cantidad);
                        }
                    }
                }
                else 
                {
                    Console.WriteLine("Por Favor digite el banco Correctamente");
                }

                Console.WriteLine("Papeletas de 1000 = {0}", c1000);
                Console.WriteLine("Papeletas de 500 = {0}", c500);
                Console.WriteLine("Papeletas de 100 = {0}", c100);
                Console.WriteLine("Cantidad no Validada = {0}", valcan);
            }


        }
    }
}
