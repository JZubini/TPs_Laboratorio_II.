using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
            :base(marca,chasis,color){}
        
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        /// <summary>
        /// Publica todos los datos del Vehiculo de tipo Ciclomotor
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder stringBuilderCiclomotor = new StringBuilder();
            stringBuilderCiclomotor.Append("CICLOMOTOR\n");
            stringBuilderCiclomotor.AppendLine(base.Mostrar());
            stringBuilderCiclomotor.AppendLine($"TAMAÑO : {this.Tamanio}");
            stringBuilderCiclomotor.AppendLine("---------------------");
            return stringBuilderCiclomotor.ToString();
        }
    }
}
