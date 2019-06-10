using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarate.Franco._2A.TP3
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;
        ENacionalidad nacionalidad;

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        #region PROPIEDADES
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string StringToDNI
        {
            set
            {
                this.dni = int.Parse(value);
            }
        }
        #endregion


        /*Abstracta, con los atributos Nombre, Apellido, Nacionalidad y DNI.
         Se deberá validar que el DNI sea correcto, teniendo en cuenta su nacionalidad. Argentino entre 1 y
        89999999 y Extranjero entre 90000000 y 99999999. Caso contrario, se lanzará la excepción
        NacionalidadInvalidaException.
         Si el DNI presenta un error de formato (más caracteres de los permitidos, letras, etc.) se lanzará
        DniInvalidoException.
         Sólo se realizarán las validaciones dentro de las propiedades.
         Validará que los nombres sean cadenas con caracteres válidos para nombres. Caso contrario, no se
        cargará.
         ToString retornará los datos de la Persona.*/
    }
}
