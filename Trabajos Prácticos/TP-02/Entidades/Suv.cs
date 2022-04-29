using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(marca,chasis, color)
        {
        }
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        /// <summary>
        /// Publica todos los datos del Vehiculo de tipo Suv
        /// </summary>
        /// <returns></returns>

        public override string Mostrar()
        {
            StringBuilder stringBuilderSuv = new StringBuilder();
            stringBuilderSuv.Append("SUV\n");
            stringBuilderSuv.AppendLine(base.Mostrar());
            stringBuilderSuv.AppendLine($"TAMAÑO : {this.Tamanio}");
            stringBuilderSuv.AppendLine("---------------------");
            return stringBuilderSuv.ToString();
        }
    }
}
