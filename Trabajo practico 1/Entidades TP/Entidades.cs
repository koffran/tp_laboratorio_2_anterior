using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TP
{
    public class Numero
    {
        //Parametros
        private double _numero; 
        //Propiedades
        private string SetNumero
        {
            set
            {
                _numero = this.ValidarNumero(value);
            }
        }

        
        public Numero() : this("0")
        {

        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        public Numero(double numero)
        {
            _numero = numero;
        }
        

        
        public void Mostrar()
        {
            Console.WriteLine(this._numero);
        }
        
        /// <summary>
        /// Valida que el parametro recibido contenga un numero del tipo double
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        public double ValidarNumero(string strNumero)
        {
            double retorno = 0;
            double.TryParse(strNumero, out retorno);
            return retorno;
        }

        // Los operadores realizarán las operaciones correspondientes entre dos números.
        public static double operator -(Numero n1, Numero n2)
        {
            return n1._numero - n2._numero;
        }
        public static double operator +(Numero n1, Numero n2)
        {
            return n1._numero + n2._numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = double.MinValue;
            if (n2._numero != 0)
                retorno = n1._numero / n2._numero;
            return retorno;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1._numero * n2._numero;
        }

        /// <summary>
        /// Retorna el numero en decimal a partir del binario pasado como parametro
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor invalido";
            double aux;
            int aux2;
            bool esNumero = double.TryParse(binario, out aux);

            if (esNumero)
            {
                aux2 = (int)aux;
                retorno = CalcularDecimal(aux2.ToString());
            }

            return retorno;
        }

        /// <summary>
        /// Realiza el calculo para pasar un numero de binario a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        static string CalcularDecimal(string binario)
        {
            int entero = 0;

            for (int i = 1; i <= binario.Length; i++)
            {
                entero += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);
            }

            return entero.ToString();
        }

        /// <summary>
        /// Retorna el numero en binario a partir del decimal pasado como parametro
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            string retorno = "Valor invalido";
            double aux;
            int aux2;
            bool esNumero = double.TryParse(numero, out aux);
            if (esNumero)
            {
                aux2 = (int)aux;
                retorno = CalcularBinario(aux2);
            }
            return retorno;
        }

        /// <summary>
        /// Retorna el numero en binario a partir del decimal pasado como parametro
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            string strNumero = numero.ToString();
            return DecimalBinario(strNumero);

        }

        /// <summary>
        /// Realiza el calculo para pasar un numero de decimal a binario
        /// </summary>
        /// <param name="entero"></param>
        /// <returns></returns>
        static string CalcularBinario(int entero)
        {
            string binario = "";
            while (entero > 0)
            {
                binario = (entero % 2).ToString() + binario;
                entero = entero / 2;
            }
            return binario;
        }
    }

    public class Calculadora
    {

        /// <summary>
        /// Realiza determinada operacion entre dos numeros dependiendo del operador recibido
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;
            string verificado = ValidarOperador(operador);

            if (verificado == "-")
            {
                retorno = num1 - num2;
            }
            else if (verificado == "+")
            {
                retorno = num1 + num2;
            }
            else if (verificado == "/")
            {
                retorno = num1 / num2;
            }
            else
            {
                retorno = num1 * num2;
            }

            return retorno;
        }

        /// <summary>
        /// Verifica que el operador recibido sea un operador valido, caso contrario retorna "+"
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static string ValidarOperador(string operador)
        {
            string retorno = "+";
            if (operador == "-" || operador == "/" || operador == "*")
                retorno = operador;

            return retorno;
        }
    }

}
