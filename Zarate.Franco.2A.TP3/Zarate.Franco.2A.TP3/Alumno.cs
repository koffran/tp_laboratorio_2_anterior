using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarate.Franco._2A.TP3
{
    public sealed class Alumno: Universitario
    {
        /* Atributos ClaseQueToma del tipo EClase y EstadoCuenta del tipo EEstadoCuenta.
 Sobreescribirá el método MostrarDatos con todos los datos del alumno.
 ParticiparEnClase retornará la cadena "TOMA CLASE DE " junto al nombre de la clase que toma.
 ToString hará públicos los datos del Alumno.
 Un Alumno será igual a un EClase si toma esa clase y su estado de cuenta no es Deudor.
 Un Alumno será distinto a un EClase sólo si no toma esa clase.*/

        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        protected EEstadoCuenta EstadoCuenta;

        protected override string ParticiparEnClase()
        {
            return "TOMA CLASE DE ";//FALTA AGREGAR LA CLASE
        }
    }
}
