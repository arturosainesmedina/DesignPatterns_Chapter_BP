using PatronStrategy.ProblemaActual;

namespace PatronStrategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productosSeleccionados = new List<Producto>() { 
                new Producto("Producto A", 25.34, TipoCuponesEnum.OFF30),
                new Producto("Producto B", 75.93, TipoCuponesEnum.OFF50),
                new Producto("Producto C", 5.87, TipoCuponesEnum.OFF10),
                new Producto("Producto D", 155.45, TipoCuponesEnum.OFF70),
                new Producto("Producto E Sin Cupon", 155.45),
            };
            Factura facturero = new Factura(productosSeleccionados);



            //Ejecucion con problemas
            facturero.ObtenerValorTotalConProblemas();
             

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //Ejecucion con patron Strategy
            //facturero.ObtenerValorTotalConPatronStrategy();




            Console.ReadKey();
        }
    }
}