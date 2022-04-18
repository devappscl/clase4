using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var opcion = "";

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("                         BIENVENIDO(A)");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Seleccione una operación: ");
            Console.WriteLine("");
            Console.WriteLine("1. Leer e imprimir tipos de datos.");
            Console.WriteLine("2. Conversiones de tipo de datos.");
            Console.WriteLine("3. Leer datos: altura, peso y nombre.");

            Console.WriteLine("");

            Console.WriteLine("Ingrese la opción: ");
            opcion = Console.ReadLine();

            Console.WriteLine("Ha seleccionado la opción: " + opcion);

            if(opcion == "1")
            {
                Console.Clear();
                rw();
            }else if(opcion == "3"){
                Console.Clear();
                apn();
            }

            Console.Clear();
            Main(args);

            
            //LEER E IMPRIMIR TIPOS DE DATOS
            void rw()
            {
                

                Console.WriteLine("Ingrese un dato: ");
                var dato = Console.ReadLine();

                int datoint;
                bool datobool;
                decimal datodecimal;

                Console.WriteLine("");

                bool successint = int.TryParse(dato, out datoint);
                bool successbool = bool.TryParse(dato, out datobool);
                bool successdecimal = decimal.TryParse(dato, out datodecimal);

                Console.WriteLine("Convertir a: ");


                if (successdecimal)
                {
                    Console.WriteLine("> Decimal = " + datodecimal + " | getType() => " + datodecimal.GetType());
                }

                if (successbool)
                {
                    Console.WriteLine("> Boolean = " + datobool + " | getType() => " + datobool.GetType());
                }
                

                if (successint)
                {
                    Console.WriteLine("> Integer = " + datoint + " | getType() => " + datoint.GetType());
                }
                else
                {
                    Console.WriteLine("> " + dato + " NO se ha podido convertir en Integer.");
                    Console.WriteLine("> String = " + dato + " | getType() => " + dato.GetType());
                }
                

               
                final();

                Console.Clear();

                rw();

            }

           

            void apn()
            {


                var alturat = "";
                var pesot = "";
                decimal altura = 0;
                decimal peso = 0;
                string nombre = "";



                Console.WriteLine("Ingrese su Altura: ");
                alturat = Console.ReadLine();
                bool successaltura = decimal.TryParse(alturat, out altura);


                if (successaltura)
                {
                    Console.WriteLine("Ingrese su Peso: ");
                    pesot = Console.ReadLine();
                    bool successpeso = decimal.TryParse(pesot, out peso);


                    if (successpeso)
                    {
                        Console.WriteLine("Ingrese su Nombre: ");
                        nombre = Console.ReadLine();

                    }
                    else
                    {
                        
                        Console.WriteLine("El valor ingresado no es correcto.");
                        Console.Clear();
                        Console.WriteLine("Datos icorrectos, vuelva a completar el formulario");
                        apn();
                    }

                }
                else
                {
                   
                    Console.WriteLine("El valor ingresado no es correcto.");
                    Console.Clear();
                    Console.WriteLine("Datos icorrectos, vuelva a completar el formulario");
                    apn();
                }

                
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Estimado(a), " + nombre + ", su altura es: " + altura + " y su peso: " + peso);

                final();

                Console.Clear();

                apn();

            }

            void final()
            {
                Console.WriteLine("");
                Console.WriteLine("¿Desea volver al menú principal? y/n:");
                var volver = Console.ReadLine();

                if (volver == "y")

                {
                    Console.Clear();
                    Main(args);
                
                }

                return;
                
            }

        }

        

        
    }

    
}
