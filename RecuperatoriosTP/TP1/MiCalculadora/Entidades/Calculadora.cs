using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida el operador recibido por parámetro y por sobrecarga realiza la suma entre los dos objetos.
        /// </summary>
        /// <param name="num1">Objeto que contiene el primer operando.</param>
        /// <param name="num2">Objeto que contiene el segundo operando.</param>
        /// <param name="operador">Operador matemática a utilizarse</param>
        /// <returns>Retorna la operación matematica solicitada</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            operador = ValidarOperador(operador);
            switch (operador)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                default:
                    return num1 / num2;
            }
        }

        /// <summary>
        /// Valida que el operador recibido por parámetro sea un operador matemático.
        /// </summary>
        /// <param name="operando">Operando a ser validado</param>
        /// <returns>En caso de que lo sea, retorna el mismo valor recibido y caso contrario, retorna el operado suma(+)</returns>

        private static char ValidarOperador(char operando)
        {
            if (operando == '+' || operando == '-' || operando == '*' || operando == '/')
            {
                return operando;
            }
            return '+';
        }
    }
}
