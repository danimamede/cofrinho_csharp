using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofrinho
{
    public class Cofre
    {

        List<Moeda> moedasCofrinho = new List<Moeda>();

        public void AdicionarMoeda(Moeda moeda)
        {
            moedasCofrinho.Add(moeda);
        }

        public bool RemoverMoeda(Moeda moedaRemover)
        {
            Moeda moeda = moedasCofrinho.Find(x => x.info() == moedaRemover.info() && x.valor == moedaRemover.valor);
            bool encontrado = (moeda != null) ? true : false;
            if (encontrado == true)
            {
                moedasCofrinho.Remove(moeda);
            }
            return encontrado;
        }

        public void ListarMoedas()
        {
            for (int m = 0; m < moedasCofrinho.Count(); m++)
            {
                Moeda moeda = moedasCofrinho[m];
                Console.WriteLine(moeda.info() + " = " + moeda.valor);
            }
        }

        public double TotalConvertido()
        {
            double soma = 0;
            for (int m = 0; m < moedasCofrinho.Count(); m++)
            {
                Moeda moeda = moedasCofrinho[m];
                soma += moeda.converter();
            }

            return soma;
        }

    }

}
