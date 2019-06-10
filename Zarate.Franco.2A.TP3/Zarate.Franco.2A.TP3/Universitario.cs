using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarate.Franco._2A.TP3
{
    public abstract class Universitario
    {
        /*Abstracta, con el atributo Legajo.
 Método protegido y virtual MostrarDatos retornará todos los datos del Universitario.
 Método protegido y abstracto ParticiparEnClase.
 Dos Universitario serán iguales si y sólo si son del mismo Tipo y su Legajo o DNI son iguales.
*/

        protected int legajo;
        
        protected virtual string MostrarDatos()
        {
            return "Retorno";
        }
        protected abstract string ParticiparEnClase();

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if(pg2.legajo == pg1.legajo)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
    }
}
