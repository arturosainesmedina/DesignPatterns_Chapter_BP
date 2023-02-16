using PatronComposite.ProblemaActual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposite.Refactorizacion
{
    public abstract class AComponente
    {
        protected double _costoServicio;
        protected string _tipoServicio;
        public int _nivelObjeto = 0;


        public AComponente(double costoServicio, string tipoServicio)
        {
            _costoServicio = costoServicio;
            _tipoServicio = tipoServicio;
        }


        public abstract double ObtenerCosto();

    }
}
