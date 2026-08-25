using Aluguel.Interfaces;
using System.Xml;

namespace Aluguel.Classes.Servicos
{
    internal class TaxaServBasil : ItaxaServ
    {
        public double Taxa(double quantia)
        {
            if (quantia < 100)
            {
                return quantia * 0.2;
            }
            else
            {
                return quantia * 0.15;
            }
        }
    }
}
