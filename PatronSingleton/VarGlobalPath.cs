﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSingleton
{
    public class VarGlobalPath : AVariablesGlobales
    {
        public VarGlobalPath()
        {
            base.SetNombreVariable("Path");
        }

        public override void EjecutarProcesoConVariable()
        {
            base.EjecutarProcesoConVariable();

            Console.WriteLine($"Yo soy una clase especializada y estoy ejecutando un proceso en el metodo override para la clase VarGlobalPath");
        }
    }
}
