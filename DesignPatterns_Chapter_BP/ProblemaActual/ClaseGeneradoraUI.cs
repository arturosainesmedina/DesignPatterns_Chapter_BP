using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory.ProblemaActual
{
    public class ClaseGeneradoraUI
    {

        public void RenderizarBotonEnWindows()
        {
            Console.WriteLine("Soy un boton renderizado en Windows");

            //Se realiza más lógica de renderizado
        }

        public void RenderizarBotonEnLinux()
        {
            Console.WriteLine("Soy un boton renderizado en Linux");

            //Se realiza más lógica de renderizado
        }

        public void RenderizarBotonEnIOS()
        {
            Console.WriteLine("Soy un boton renderizado en IOS");

            //Se realiza más lógica de renderizado
        }


        public void OnClickBotonEnWindows()
        {
            Console.WriteLine("Diste click en el botón de Windows");


            //Se ejecuta más lógica
        }

        public void OnClickBotonEnLinux()
        {
            Console.WriteLine("Diste click en el botón de Linux");

            //Se ejecuta más lógica
        }

        public void OnClickBotonEnIOS()
        {
            Console.WriteLine("Diste click en el botón de IOS");


            //Se ejecuta más lógica
        }
    }
}
