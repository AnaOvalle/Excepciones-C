using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesC
{
    class Program
    {
        static void Main(string[] args)
        {
            try   
            {
                //Declaración y captura de datos
                Console.Write("Enter number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                // Division y despliegue de resultado
                Console.WriteLine("Resultado: " + num1 / num2);
                // Detener pantalla
                Console.ReadKey();
            }

            catch (DivideByZeroException e)  //Excepción 1
            {
                Console.WriteLine("\nERROR: " + e.Message);
            }

            catch (FormatException e) // Excepción 2
            {
                Console.WriteLine("\nERROR: " + e.Message);
            }

            finally
            {
                // Vacío
            }

        }
    }
}
