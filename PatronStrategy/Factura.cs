using PatronStrategy.ProblemaActual;
using PatronStrategy.Refactorizacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy
{
    public class Factura
    {
        private List<Producto> _productos = null;
        private Contexto _contexto = new Contexto();


        public Factura()
        {
            _productos = new List<Producto>();
        }

        public Factura(List<Producto> productosSeleccionados): this()
        {
            _productos.AddRange(productosSeleccionados);
        }


        public void AgregarProducto(Producto productoNuevo)
        { 
            _productos.Add(productoNuevo);
        }


        public void ObtenerValorTotalConProblemas()
        {
            double valorTotalSinDescuento = 0;
            double totalDescuento = 0;
            Cuponera cuponera = new Cuponera();

            foreach (Producto producto in _productos)
            {
                valorTotalSinDescuento += producto.Valorimponible;
                totalDescuento += cuponera.AplicarCuponAProducto(producto);
            }


            Console.WriteLine($"Valor imponible: {valorTotalSinDescuento}");
            Console.WriteLine($"Descuento total aplicable: {totalDescuento}");
            Console.WriteLine($"Valor Final: {valorTotalSinDescuento - totalDescuento}");

        }



        public void ObtenerValorTotalConPatronStrategy()
        {
            double valorTotalSinDescuento = 0;
            double totalDescuento = 0;

            foreach (Producto producto in _productos)
            {
                valorTotalSinDescuento += producto.Valorimponible;
                totalDescuento += _contexto.AplicarCupon(producto);
            }


            Console.WriteLine($"Valor imponible: {valorTotalSinDescuento}");
            Console.WriteLine($"Descuento total aplicable: {totalDescuento}");
            Console.WriteLine($"Valor Final: {valorTotalSinDescuento - totalDescuento}");
        }
    }
}
