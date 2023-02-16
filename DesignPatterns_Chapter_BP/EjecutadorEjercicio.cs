using PatronFactory.ProblemaActual;
using PatronFactory.Refactorizacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory
{
    public class EjecutadorEjercicio
    {
        private readonly string _sistemaOperativo;
        private readonly ClaseGeneradoraUI _genUI;

        public EjecutadorEjercicio(string sistemaOperativo)
        {
            _genUI = new ClaseGeneradoraUI();
            _sistemaOperativo = sistemaOperativo;
        }

        public void EjecutarEjemploConProblema()
        {
            switch (_sistemaOperativo.ToLower())
            {
                case "windows":
                    _genUI.RenderizarBotonEnWindows();
                    _genUI.OnClickBotonEnWindows();
                    break;

                case "linux":
                    _genUI.RenderizarBotonEnLinux();
                    _genUI.OnClickBotonEnLinux();
                    break;

                case "ios":
                    _genUI.RenderizarBotonEnIOS();
                    _genUI.OnClickBotonEnIOS();
                    break;


                default:
                    Console.WriteLine("Sistema operativo no soportado");
                    break;
            }
        }













        public void EjecutarEjemploConPatronFactory()
        {
            IBoton boton = null;

            switch (_sistemaOperativo.ToLower())
            {
                case "windows":
                    boton = new BotonWindowsRefectored();
                    break;

                case "linux":
                    boton = new BotonLinuxRefactored();
                    break;

                case "ios":
                    boton = new BotonIOSRefactored();
                    break;

                case "android":
                    boton = new BotonAndroidRefactored();
                    break;

                case "html":
                    boton = new BotonHTMLRefactored();
                    break;

                default:
                    Console.WriteLine("Sistema operativo no soportado");
                    break;
            }


            if (boton != null)
            {
                boton.RenderizarBoton();
                boton.OnClick();
            }
        }

    }
}
