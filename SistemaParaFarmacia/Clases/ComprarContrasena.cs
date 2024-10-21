using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParaFarmacia.Clases
{
    public class ComprarContrasena
    {
        public bool SonIguales(string contrasena1, string contrasena2)
        {
            // Comparamos las dos contraseñas
            return contrasena1 == contrasena2;
        }
    }
}
