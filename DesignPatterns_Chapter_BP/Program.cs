using PatronFactory;
using PatronFactory.ProblemaActual;
using System.Windows.Input;

namespace DesignPatterns_Chapter_BP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey consoleKey = ConsoleKey.A;
            while (consoleKey != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("Escriba el sistema operativo requerido:");
                Console.WriteLine("Windows");
                Console.WriteLine("Linux");
                Console.WriteLine("IOS");

                Console.Write("---> ");

                string sistemaoperativo = Console.ReadLine();
                var ejecProb = new EjecutadorEjercicio(sistemaoperativo);

                //Ejecucion codigo con problema
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("------Ejecucion de codigo con problemas:");
                ejecProb.EjecutarEjemploConProblema();




                //Ejecucion codigo refactorizado con Patrón Factory
                Console.WriteLine();
                Console.WriteLine();
                //Console.WriteLine("------Ejecucion de codigo con patrón Factory:");
                //ejecProb.EjecutarEjemploConPatronFactory();






                consoleKey = Console.ReadKey().Key;
            }




        }
    }
}