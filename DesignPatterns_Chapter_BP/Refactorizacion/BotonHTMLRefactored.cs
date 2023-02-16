using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory.Refactorizacion
{
    public class BotonHTMLRefactored : IBoton
    {
        public void OnClick()
        {
            Console.WriteLine("Diste click en el botón de HTML");

            //Se realiza más lógica de renderizado
        }

        public void RenderizarBoton()
        {
            Console.WriteLine("Soy un boton renderizado en HTML");
            

            //Se realiza más lógica de renderizado
        }
    }
}
