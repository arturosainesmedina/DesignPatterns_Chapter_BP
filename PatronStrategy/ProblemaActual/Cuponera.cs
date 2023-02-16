using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.ProblemaActual
{
    public class Cuponera
    {
        public double AplicarCuponAProducto(Producto producto)
        {
            if(producto.CuponAplicable != null)
                switch (producto.CuponAplicable)
                {
                    case TipoCuponesEnum.OFF10:
                        Console.WriteLine($"Se aplica cupón de 10 % de descuento al producto {producto.NombreProducto}");
                        return producto.Valorimponible * 0.1;
                     

                    case TipoCuponesEnum.OFF30:
                        Console.WriteLine($"Se aplica cupón de 30 % de descuento al producto {producto.NombreProducto}");
                        return producto.Valorimponible * 0.3;
                      

                    case TipoCuponesEnum.OFF50:
                        Console.WriteLine($"Se aplica cupón de 50 % de descuento al producto {producto.NombreProducto}");
                        return producto.Valorimponible * 0.5;
                       

                    case TipoCuponesEnum.OFF70:
                        Console.WriteLine($"Se aplica cupón de 70 % de descuento al producto {producto.NombreProducto}");
                        return producto.Valorimponible * 0.7;
           

                    default:
                        Console.WriteLine($"Cupon no existe");
                        return producto.Valorimponible * 0;
   
                }


            return 0;
        }

    }
}
