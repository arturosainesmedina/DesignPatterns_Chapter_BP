using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Refactorizacion
{
    public class Cupon50OFF : ICuponEstrategia
    {
        public double AplicarCupon(Producto producto)
        {
            Console.WriteLine($"Se aplica cupón de 50 % de descuento al producto {producto.NombreProducto}");
            return producto.Valorimponible * 0.5;
        }
    }
}
