using System;

namespace EJERCICIO1
{
    /********************************
     * Práctica 1: Calculadora      *
     * Autor: Unai Echeverria       *
     * ******************************/
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos e inicializamos las variables
            decimal num1 = 0, num2 = 0, resultado = 0, continuar = 1;
            string respuesta = "";

            try
            {
                //Configuración de la consola
                Console.ForegroundColor = ConsoleColor.Black; //color de letra
                Console.BackgroundColor = ConsoleColor.Gray;  //color de fondo
                Console.Clear(); //refrescar para forzar la asignación de colores al inicio

                Console.WriteLine("****************CALCULADORA****************");

                //Bucle del programa
                for (int i = 0; i < continuar; i++)
                {
                    //Pedimos la operación a realizar
                    Console.WriteLine("Escoge la operación a realizar:\n1. Suma (+)\n2. Resta (-)\n3. Multiplicación (*)\n4. División (/)");
                    string operacion = Console.ReadLine();

                    //Pedimos que indique dos números
                    Console.Write("\nIntroduce un número: ");
                    num1 = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Introduce otro número: ");
                    num2 = Convert.ToDecimal(Console.ReadLine());

                    //Controlar error al dividir por 0
                    if (num2 == 0 && operacion.Equals("4")) {
                        throw new ArgumentException("división por 0.");
                    }

                    //Realizamos la operación correspondiente
                    switch (operacion)
                    {
                        case "1":
                            resultado = num1 + num2;
                            break;
                        case "2":
                            resultado = num1 - num2;
                            break;
                        case "3":
                            resultado = num1 * num2;
                            break;
                        case "4":
                            resultado = num1 / num2;
                            break;
                        default:
                            Console.WriteLine("La operación escogida no es válida.");
                            break;
                    }
                    //Mostramos el resultado
                    Console.WriteLine("Resultado: " + resultado);

                    //Preguntamos si queremos continuar o no
                    Console.WriteLine("¿Quieres seguir utilizando la calculadora? (S/N)");
                    respuesta = Console.ReadLine();
                    if (respuesta.ToUpper().Equals("S"))
                    {
                        //Continuamos el bucle limpiando la pantalla
                        continuar++;
                        Console.Clear();

                    }
                    else
                    {
                        //Finaliza la aplicación
                        Console.WriteLine("Pulsa cualquier tecla para cerrar la aplicación.");
                        Console.ReadKey();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error inesperado, contacta con soporte.");
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine("Pulsa cualquier tecla para cerrar la aplicación.");
                Console.ReadKey();
            }
           
        }
    }
}
