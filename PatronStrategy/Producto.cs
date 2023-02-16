using PatronStrategy.ProblemaActual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy
{
    public class Producto
    {
        private string _nombreProducto { get; set; }
        private double _valorImponible { get; set; }
        private TipoCuponesEnum? _cuponAplicable { get; set; }


        public Producto(string nombreProducto, double valor)
        {
            _nombreProducto = nombreProducto;
            _valorImponible = valor;
        }

        public Producto(string nombreProducto, double valor, TipoCuponesEnum? cuponAplicable)
        {
            _nombreProducto = nombreProducto;
            _valorImponible = valor;
            _cuponAplicable = cuponAplicable;
        }


        public string NombreProducto { get { return _nombreProducto; } }
        public double Valorimponible { get { return _valorImponible; } }
        public TipoCuponesEnum? CuponAplicable { get { return _cuponAplicable; } }


    }
}
