using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposite.ProblemaActual
{
    public class Caja
    {
        private const string TIPO_SERVICIO = "Empaquetado";
        private TamanosCajasEnum _tamanoCaja;
        private double _costoServicio;


        public Caja(TamanosCajasEnum tamanoCaja, double costoServicio)
        {
            _tamanoCaja = tamanoCaja;
            _costoServicio = costoServicio;
        }

        public string TipoServicio => TIPO_SERVICIO;

        public TamanosCajasEnum TamanoCaja => _tamanoCaja;

        public double CostoServicio => _costoServicio;

    }
}
