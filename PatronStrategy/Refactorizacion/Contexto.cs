using PatronStrategy.ProblemaActual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Refactorizacion
{
    public class Contexto
    {
        //private ICuponEstrategia cuponAplicable;

        private Dictionary<TipoCuponesEnum, ICuponEstrategia> CuponesDisponibles = new Dictionary<TipoCuponesEnum, ICuponEstrategia>();


        public Contexto()
        {
            CuponesDisponibles.Add(TipoCuponesEnum.OFF10, new Cupon10OFF());
            CuponesDisponibles.Add(TipoCuponesEnum.OFF30, new Cupon30OFF());
            CuponesDisponibles.Add(TipoCuponesEnum.OFF50, new Cupon50OFF());
            CuponesDisponibles.Add(TipoCuponesEnum.OFF70, new Cupon70OFF());
        }



        //public void SetCupon(ICuponEstrategia cupon)
        //{ 
        //    cuponAplicable = cupon;
        //}


        public double AplicarCupon(Producto producto)
        {

            ICuponEstrategia cuponAplicable = null;

            if (producto.CuponAplicable.HasValue && CuponesDisponibles.TryGetValue(producto.CuponAplicable.Value, out cuponAplicable))
            {
                return cuponAplicable.AplicarCupon(producto);
            }
            else
                return 0;
            
        }

    }
}
