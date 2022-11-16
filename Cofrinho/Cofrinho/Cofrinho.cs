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

        public void RemoverMoeda(Moeda moedaRemover)
        {
            bool encontrado = false;
            for (int m = 0; m < moedasCofrinho.Count(); m++)
            {
                Moeda moeda = moedasCofrinho[m];
                if (moedaRemover.valor == moeda.valor && moedaRemover.info() == moeda.info())
                {
                    moedasCofrinho.Remove(moeda);
                    encontrado = true;
                }
            }
            if (encontrado == true)
            {
                Console.WriteLine("Moeda removida com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor de moeda não encontrada. Tente novamente.");
            }

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
                soma = soma + moeda.converter();
            }

            return soma;
        }

    }

}
