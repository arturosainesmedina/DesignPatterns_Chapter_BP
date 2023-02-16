using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSingleton
{
    public abstract class AVariablesGlobales
    {
        private string _nombreVariable;

        //protected AVariablesGlobales(string nombreVariable)
        //{
        //    _nombreVariable = nombreVariable;
        //}


        public string Nombre => _nombreVariable;

        public string Valor { get; set; }


        protected void SetNombreVariable(string nombreVariable)
        {
            _nombreVariable = nombreVariable;
        }

        public virtual void EjecutarProcesoConVariable()
        {
            Console.WriteLine($"Hola, yo soy la variable {this._nombreVariable} y mi valor es {this.Valor}");
        }
    }
}
