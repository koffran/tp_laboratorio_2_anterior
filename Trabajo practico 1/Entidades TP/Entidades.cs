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
        
        /*ValidarNumero comprobará que el valor recibido sea numérico, y lo retornará en
         formato double. Caso contrario, retornará 0.*/
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

        static string CalcularDecimal(string binario)
        {
            int entero = 0;

            for (int i = 1; i <= binario.Length; i++)
            {
                entero += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);
            }

            return entero.ToString();
        }

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

        public string DecimalBinario(double numero)
        {
            string strNumero = numero.ToString();
            return DecimalBinario(strNumero);

        }

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

        /*2. El método Operar será de clase:
            a.Validará y realizará la operación pedida entre ambos números.
            b.Si se tratara de una división por 0, retornará double.MinValue.*/
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

        /*El método ValidarOperador será privado y estático.Deberá validar que el operador
        recibido sea +, -, / o*. Caso contrario retornará +.*/

        private static string ValidarOperador(string operador)
        {
            string retorno = "+";
            if (operador == "-" || operador == "/" || operador == "*")
                retorno = operador;

            return retorno;
        }
    }

}
