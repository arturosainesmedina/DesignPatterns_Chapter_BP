using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSingleton
{
    public class VariablesGlobalesSingleton
    {
        private static AVariablesGlobales _variablePath = null;
        private static AVariablesGlobales _variableSystem = null;

        private VariablesGlobalesSingleton()
        { 
            
        }


        public static AVariablesGlobales GetInstanciaVarPath() 
        {
            if (_variablePath == null)
                _variablePath = new VarGlobalPath();


            return _variablePath;
        }


        public static AVariablesGlobales GetInstanciaVarSystem()
        {
            if (_variableSystem == null)
                _variableSystem = new VarGlobalSystem();


            return _variableSystem;
        }
    }
}
