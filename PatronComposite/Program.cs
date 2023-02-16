using PatronComposite.ProblemaActual;
using PatronComposite.Refactorizacion;

namespace PatronComposite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factura factura = null;


            /////////////////////////
            //Ejecución de ejemplo con problema
            ////////////////////////
            List<Producto> productos = new List<Producto>(){
                new Producto("Camiseta Hombre", 25.35),
                new Producto("Pantalon Hombre", 43.21),
                new Producto("Zapatos Tenis", 133.29)
            };

            List<Caja> cajas = new List<Caja>() {
                new Caja(TamanosCajasEnum.SMALL, 0.25),
                new Caja(TamanosCajasEnum.MEDIUM, 0.35),
                new Caja(TamanosCajasEnum.BIG, 1.00)
            };

            factura = new Factura(cajas, productos);
            factura.CalcularValorTotalConProblema();



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            ////////////////////////////
            //Ejecucion de ejemplo con patrón Composite
            /////////////////////////////
            //AComponente cajaParaPantalon = new CajaComponente(TamanosCajasEnum.SMALL, 0.25);
            //((CajaComponente)cajaParaPantalon).AgregarComponente(new ProductoComponente("Pantalon Hombre", 43.21));

            //AComponente cajaParaZapatos = new CajaComponente(TamanosCajasEnum.MEDIUM, 0.35);
            //((CajaComponente)cajaParaZapatos).AgregarComponente(new ProductoComponente("Zapatos Tenis", 133.29));


            //AComponente cajaPrincipal = new CajaComponente(
            //    TamanosCajasEnum.BIG, 1.00,

            //     new List<AComponente>() {
            //         new ProductoComponente("Camiseta Hombre", 25.35), 
            //         cajaParaPantalon, 
            //         cajaParaZapatos } );


            //factura = new Factura(cajaPrincipal);
            //factura.CalcularValorTotalConPatronComposite();


            Console.ReadKey();

        }




        

    }
}