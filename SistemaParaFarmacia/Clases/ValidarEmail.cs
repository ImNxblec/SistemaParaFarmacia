using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SistemaParaFarmacia.Clases
{
    public class ValidarEmail
    {
        public bool ValidarCorreo(string correo)
        {
            // Expresión regular para validar el correo
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Utilizamos Regex para comprobar si el correo sigue el patrón
            return Regex.IsMatch(correo, patronCorreo);
        }
    }
}
