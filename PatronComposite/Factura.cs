using PatronComposite.ProblemaActual;
using PatronComposite.Refactorizacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposite
{
    public class Factura
    {
        private List<Caja> _cajas;
        private List<Producto> _productos;

        public Factura(List<Caja> cajas, List<Producto> productos)
        {
            _cajas = cajas;
            _productos = productos;
        }




        private AComponente _serviciosYProductos;

        public Factura(AComponente serviciosYProductos)
        { 
            _serviciosYProductos = serviciosYProductos;
        }





        public void CalcularValorTotalConProblema()
        {
            double costoTotal = 0;
            Console.WriteLine("La factura tiene los siguientes ITEMS: ");
            foreach (Caja caja in _cajas)
            {
                costoTotal += caja.CostoServicio;
                Console.WriteLine($"Servicio: {caja.TipoServicio} - Tamaño: {Enum.GetName<TamanosCajasEnum>(caja.TamanoCaja)} - Costo: {caja.CostoServicio}");
            }



            foreach (Producto producto in _productos)
            {
                costoTotal += producto.CostoServicio;
                Console.WriteLine($"Servicio: {producto.TipoServicio} - Nombre: {producto.NombreProducto} - Costo: {producto.CostoServicio}");
            }


            Console.WriteLine($"el valor total de la factura es ${costoTotal.ToString()}");

        }



        public void CalcularValorTotalConPatronComposite()
        {
            double costoTotal = 0;
            Console.WriteLine("La factura tiene los siguientes ITEMS: ");

            costoTotal = _serviciosYProductos.ObtenerCosto();

            Console.WriteLine($"el valor total de la factura es ${costoTotal.ToString()}");

        }
    }
}
