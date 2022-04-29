using System;
using System.Text;
namespace Entidades
{
    public class Operando
    {
        private double numero;

        public Operando()
        {
            numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            this.numero = Convert.ToDouble(strNumero);
        }

        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }


        /// <summary>
        /// Transforma el string pasado por parámetro en double.
        /// </summary>
        /// <param name="strNumero">Valor a verificar</param>
        /// <returns>Retorna el numero convertido</returns>
        public double ValidarOperando(string strNumero)
        {
            double numeroConvertido;
            double.TryParse(strNumero, out numeroConvertido);
            return numeroConvertido;
        }

        /// <summary>
        /// Verifica que el valor pasado por parámetro es un nunmero binario
        /// </summary>
        /// <param name="binario">Valor a verificar</param>
        /// <returns>Retorna: false si NO es un número binario 
        ///                   true si es un número binario</returns>

        private bool EsBinario(string binario)
        {
            foreach (char item in binario)
            {
                if (item != '0' && item != '1')
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Verifica si el numero recibido por parámetro es binario y si es así, convierte el valor de binario a decimal.
        /// </summary>
        /// <param name="binario">Valor a convertir</param>
        /// <returns>Retorna el numero convertido</returns>

        public string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
            {
                int potencias;
                double acumuladorOperacion;
                potencias = binario.Length;
                potencias--;
                acumuladorOperacion = 0;
                foreach (char item in binario)
                {
                    acumuladorOperacion = acumuladorOperacion + (Char.GetNumericValue(item) * Math.Pow(2, potencias));
                    potencias--;
                }
                return acumuladorOperacion.ToString();
            }
            else
            {
                return "Valor inválido";
            }
        }

        /// <summary>
        /// Convierte el valor de tipo double recibido por parámetro y lo transforma a binario.
        /// </summary>
        /// <param name="numero">Valor a convertir</param>
        /// <returns>Retorna el numero convertido</returns>

        public string DecimalBinario(double numero)
        {
            double valorAbsoluto;
            int valorEntero;
            int operacionDivision;
            int operacionResto;
            StringBuilder retornoFuncion;
            valorAbsoluto = Math.Abs(numero);
            valorEntero = (int)Math.Floor(valorAbsoluto);
            retornoFuncion = new StringBuilder();
            do
            {
                operacionDivision = valorEntero / 2;
                operacionResto = valorEntero % 2;
                retornoFuncion.Append(operacionResto);
                valorEntero = operacionDivision;
            } while (valorEntero > 0);
            return retornoFuncion.ToString();
        }

        /// <summary>
        /// Convierte el valor de tipo string recibido por parámetro y lo transforma a binario.
        /// </summary>
        /// <param name="numero">Valor a convertir</param>
        /// <returns>Retorna el numero convertido</returns>

        public string DecimalBinario(string numero)
        {
            double valorConvertido;
            double valorAbsoluto;
            int valorEntero;
            int operacionDivision;
            int operacionResto;
            StringBuilder retornoFuncion;
            valorConvertido = Convert.ToDouble(numero);
            valorAbsoluto = Math.Abs(valorConvertido);
            valorEntero = (int)Math.Floor(valorAbsoluto);
            retornoFuncion = new StringBuilder();
            do
            {
                operacionDivision = valorEntero / 2;
                operacionResto = valorEntero % 2;
                retornoFuncion.Append(operacionResto);
                valorEntero = operacionDivision;
            } while (valorEntero > 0);
            return retornoFuncion.ToString();
        }

        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1,Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }

    }
    
}