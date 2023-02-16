using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposite.ProblemaActual
{
    public class Producto
    {
        private const string TIPO_SERVICIO = "Producto";
        private string _nombreProducto;
        private double _costoServicio;



        public Producto(string nombreProducto, double costoServicio)
        { 
            _nombreProducto = nombreProducto;
            _costoServicio = costoServicio;
        }



        public string TipoServicio => TIPO_SERVICIO;

        public string NombreProducto => _nombreProducto;

        public double CostoServicio => _costoServicio;





    }
}
