using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas }
        private ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(marca, chasis, color)
        {
            this.tipo = ETipo.CuatroPuertas;
        }

        public Sedan(EMarca marca, string chasis, ConsoleColor color,ETipo tipo)
            : base(marca, chasis, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return this.tamanio;
            }
        }

        /// <summary>
        /// Publica todos los datos del Vehiculo de tipo Sedan
        /// </summary>
        /// <returns></returns>

        public override string Mostrar()
        {
            StringBuilder stringBuilderSedan = new StringBuilder();
            stringBuilderSedan.Append("SEDAN\n");
            stringBuilderSedan.AppendLine(base.Mostrar());
            stringBuilderSedan.AppendLine($"TAMAÑO : {this.Tamanio}");
            stringBuilderSedan.AppendLine($"TIPO: {this.tipo}");
            stringBuilderSedan.AppendLine("---------------------");
            return stringBuilderSedan.ToString();
        }
    }
}
