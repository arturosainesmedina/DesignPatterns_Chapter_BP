using PatronComposite.ProblemaActual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposite.Refactorizacion
{
    public class CajaComponente : AComponente
    {
        private List<AComponente> productosHijos = new List<AComponente>();
        private TamanosCajasEnum _tamanoCaja;
        


        public CajaComponente(TamanosCajasEnum tamanoCaja, double costoServicio) : base(costoServicio, "Empaquetado")
        {
            _tamanoCaja = tamanoCaja;
        }

        public CajaComponente(TamanosCajasEnum tamanoCaja, double costoServicio, List<AComponente> otrosComponentes) : base(costoServicio, "Empaquetado")
        {
            _tamanoCaja = tamanoCaja;
            productosHijos.AddRange(otrosComponentes);
        }


        public void AgregarComponente(AComponente componente)
        {
            productosHijos.Add(componente);
        }


        public override double ObtenerCosto()
        {
            double costosHijos = 0;

            for(int i = 0; i <= this._nivelObjeto; i++) Console.Write("  ");
            Console.WriteLine($"*Servicio: {this._tipoServicio} - Tamaño: {Enum.GetName<TamanosCajasEnum>(this._tamanoCaja)} - Costo: {this._costoServicio}");


            foreach (AComponente componente in productosHijos )
            {
                componente._nivelObjeto = this._nivelObjeto + 1;
                costosHijos += componente.ObtenerCosto();
            }

            return _costoServicio + costosHijos;
        }
    }
}
