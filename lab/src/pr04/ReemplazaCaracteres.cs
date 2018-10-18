using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr04_Strategy_Examples
{
    public class ReemplazaCaracteres
    {
        // Metodo que reemplaza las 'y' de una cadena de caracteres 
        // por 'll' 
        public String desargentinizar(String name)
        {
            return name.Replace("y", "ll");
        } // desargentinizar
    } // class ReemplazaCaracteres
} // namespace
