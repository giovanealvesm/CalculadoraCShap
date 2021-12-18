using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCalculadora
{
    /// <summary>
    /// Caulcula a tabuada.
    /// </summary>
    public class Tabuada
    {
        /// <summary>
        /// Número do qual será calculada a tabuada.
        /// </summary>
        public int Numero { get; }

        public Tabuada(int numero)
        {
            Numero = numero;
        }

        /// <summary>
        /// Realiza o cáculo da tabuada.
        /// </summary>
        /// <param name="de">
        /// Início do intervalo para cálculo da taboada.
        /// </param>
        /// <param name="ate">
        /// Final do intervalo para cálculo da tabuada.
        /// </param>
        /// <returns>
        /// Tabuada do número informado dentro do intervalo fornecido.
        /// </returns>
        public string Calcular(int de, int ate)
        {
            var sb = new StringBuilder();
            for(int i = de; i <= ate; i++)
            {
                sb.AppendLine($"{Numero} x {i} = {OperacoesAritimeticas.Multiplicacao(Numero, i)}");
            }
            return sb.ToString();
        }
    }
}
