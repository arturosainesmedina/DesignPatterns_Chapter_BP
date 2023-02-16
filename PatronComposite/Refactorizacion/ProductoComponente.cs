using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposite.Refactorizacion
{
    public class ProductoComponente : AComponente
    {
        private string _nombreProducto;


        public ProductoComponente(string nombreProducto, double costoServicio) : base(costoServicio, "Producto")
        {
            _nombreProducto = nombreProducto;
        }


        public override double ObtenerCosto()
        {
            for (int i = 0; i <= this._nivelObjeto; i++) Console.Write("  ");
            Console.WriteLine($"├- Servicio: {this._tipoServicio} - Nombre: {this._nombreProducto} - Costo: {this._costoServicio}");

            return _costoServicio;
        }
    }
}
