using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresNumericos15
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            string cadenaUno;
          
            Validador.Bienvenida();

            cadenaUno = Validador.ValidarString("\n Ingrese una frase");

            Validador.MostrarString(cadenaUno);
 
            Validador.CompararStringConNumero(cadenaUno);

            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
