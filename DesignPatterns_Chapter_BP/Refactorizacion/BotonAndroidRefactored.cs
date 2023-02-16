using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory.Refactorizacion
{
    public class BotonAndroidRefactored : IBoton
    {
        public void OnClick()
        {
            Console.WriteLine("Diste click en el botón de Android");

            //Se realiza más lógica de renderizado
        }

        public void RenderizarBoton()
        {
            Console.WriteLine("Soy un boton renderizado en Android");
            

            //Se realiza más lógica de renderizado
        }
    }
}
