﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarate.Franco._2A.TP3
{
    public sealed class Profesor:Universitario
    {
        /*Atributos ClasesDelDia del tipo Cola y random del tipo Random y estático.
 Sobrescribir el método MostrarDatos con todos los datos del profesor.
 ParticiparEnClase retornará la cadena "CLASES DEL DÍA" junto al nombre de la clases que da.
 ToString hará públicos los datos del Profesor.
 Se inicializará a Random sólo en un constructor.
 En el constructor de instancia se inicializará ClasesDelDia y se asignarán dos clases al azar al Profesor
mediante el método randomClases. Las dos clases pueden o no ser la misma.
 Un Profesor será igual a un EClase si da esa clase.*/

        public static Random random;

        protected override string MostrarDatos()
        {
            return this.legajo.ToString(); 
        }

        protected override string ParticiparEnClase()
        {
            return "CLASES DEL DIA"; //FALTA LA CLASE
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
