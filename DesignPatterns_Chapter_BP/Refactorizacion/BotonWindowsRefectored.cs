using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory.Refactorizacion
{
    public class BotonWindowsRefectored : IBoton
    {
        public void OnClick()
        {
            Console.WriteLine("Diste click en el botón de Windows");
            

            //Se realiza más lógica de renderizado
        }

        public void RenderizarBoton()
        {
            Console.WriteLine("Soy un boton renderizado en Windows");

            //Se realiza más lógica de renderizado
        }
    }
}
