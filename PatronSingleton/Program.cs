namespace PatronSingleton
{
    static class Program
    {
        static void Main(string[] args)
        {

            //Ejecucion sin Singleton
            Console.WriteLine("Se ejecuta el codigo SIN singleton: ");
            EjecutarCodigoSinSingleton();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Ejecucion con Singleton
            Console.WriteLine("Se ejecuta el codigo CON singleton: ");
            EjecutarCodigoConSingleton();


            Console.ReadKey();
        }










        public static void EjecutarCodigoSinSingleton()
        {
            AVariablesGlobales varPath1 = new VarGlobalPath();
            AVariablesGlobales varSys1 = new VarGlobalSystem();

            //Valor inicial
            varPath1.Valor = "10";
            varSys1.Valor = "15";
            varPath1.EjecutarProcesoConVariable();
            varSys1.EjecutarProcesoConVariable();


            //Se seta un valor nuevo desde el objeto varPath1 y el resultado NO se ve reflejado en la variable varPath2 porque son 2 instancias diferentes, y por ende, valores diferentes
            varPath1.Valor = "50";
            AVariablesGlobales varPath2 = new VarGlobalPath();
            varPath2.EjecutarProcesoConVariable();
        }





        public static void EjecutarCodigoConSingleton()
        {
            AVariablesGlobales varPath1 = VariablesGlobalesSingleton.GetInstanciaVarPath();
            AVariablesGlobales varSys1 = VariablesGlobalesSingleton.GetInstanciaVarSystem();

            //Valor inicial
            varPath1.Valor = "10";
            varSys1.Valor = "15";
            varPath1.EjecutarProcesoConVariable();
            varSys1.EjecutarProcesoConVariable();


            //Se seta un valor nuevo desde el objeto varPath1 y el resultado se ve reflejado en la variable varPath2
            varPath1.Valor = "50";
            AVariablesGlobales varPath2 = VariablesGlobalesSingleton.GetInstanciaVarPath();
            varPath2.EjecutarProcesoConVariable();
        }
    }
}