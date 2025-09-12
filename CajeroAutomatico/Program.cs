using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    internal class Program
    {
        // Función para mostrar el menú
        //Subproblema #1: Mostrar el menu para que el usuario sepa que opciones tiene disponibles
        static void MostrarMenu()
        {
            Console.WriteLine("Cajero Automático");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1. Consultar saldo");
            Console.WriteLine("2. Depositar dinero");
            Console.WriteLine("3. Retirar dinero");
            Console.WriteLine("0. Salir");
            Console.Write("Selecione la acción que desea realizar: ");
        }
        // Función para manejar depósitos
        //Subproblema #2: Hacer la suma del deposito al saldo actual
        static double deposito(double saldo, double monto)
        {
            saldo += monto;
            Console.WriteLine($"Su nuevo saldo es: C${saldo}");
            return saldo;
        }
        // Función para manejar retiros
        //Subproblema #3: Hacer la resta del deposito al saldo actual
        static double retiro(double saldo, double monto)
        {
            if (monto > saldo)
            {
                Console.WriteLine("Fondos insuficientes.");
            }
            else
            {
                saldo -= monto;
                Console.WriteLine($"Su nuevo saldo es: C${saldo}");
            }
            return saldo;
        }
        static void Main(string[] args)
        {
            int opc;
            double saldo = 0;
            // Manejo de excepciones para entradas no válidas
           
                // Bucle del cajero automático
                //Subproblema #4: Generar un bucle para que el usuario pueda hacer la cantidad necesaria de procedimientos
                do
                {
                    MostrarMenu();
                    opc = Convert.ToInt32(Console.ReadLine());
                
                    switch (opc)
                    {
                        case 1:
                            Console.WriteLine("--------------------------");
                            Console.WriteLine($"Su saldo actual es: C${saldo}");
                            break;
                        case 2:
                            try
                            {
                                Console.WriteLine("--------------------------");
                                Console.Write("Ingrese el monto a depositar: C$");
                                double montoDeposito = Convert.ToDouble(Console.ReadLine());
                                saldo = deposito(saldo, montoDeposito);

                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine("Error: Entrada no válida. Por favor, ingrese un número." + ex.Message);
                            }
                        break;
                        case 3:
                            try
                            {
                                Console.WriteLine("--------------------------");
                                Console.Write("Ingrese el monto a retirar: C$");
                                double montoRetiro = Convert.ToDouble(Console.ReadLine());
                                saldo = retiro(saldo, montoRetiro);
                            }   
                            catch (FormatException ex)
                            {
                                Console.WriteLine("Error: Entrada no válida. Por favor, ingrese un número." + ex.Message);
                            }
                            break;
                        case 0:
                            Console.WriteLine("Operaciones completadas. Saliendo...");
                            opc = 0;
                            Console.WriteLine("\nPresiona ENTER para terminar el programa...");
                            Console.ReadLine();
                        break;
                        default:
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("Opción no válida.");
                            break;
                        }
                    
                }while(opc != 0);


           
        }
    }
}
