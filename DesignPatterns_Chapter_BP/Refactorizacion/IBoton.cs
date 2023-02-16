using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory.Refactorizacion
{
    public interface IBoton
    {
        void RenderizarBoton();

        void OnClick();

    }
}
