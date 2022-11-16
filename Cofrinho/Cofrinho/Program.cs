using Cofrinho;
using System;

internal class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("COFRINHO DA DANI");
        Console.WriteLine("Por favor digite a opção desejada:");

        var cofrinho = new Cofre();
        int selectMenu;

        do
        {
            Console.Clear();
            Console.WriteLine("\n1. Adicionar moeda\n2. Remover moeda\n3. Listar moedas no cofrinho\n4. Consultar valor total em reais\n5. Encerrar");

            int.TryParse(Console.ReadLine(), out selectMenu);
                                  

            switch (selectMenu)
            {
                case 1:
                    cofrinho.AdicionarMoeda(SelectMoeda());
                    Console.WriteLine("Moeda adicionada com sucesso");
                    break;
                case 2:
                    RemoverMoeda();
                    break;
                case 3:
                    Console.WriteLine("\nMoedas no cofrinho:");
                    cofrinho.ListarMoedas();
                    break;
                case 4:
                    cofrinho.TotalConvertido();
                    Console.WriteLine("\nTotal convertido em real: R$" + cofrinho.TotalConvertido());
                    break;
                case 5:
                    Console.WriteLine("\nEncerrando... Sistema finalizado.");
                    break;
                default:
                    Console.WriteLine("\nPor favor escolha uma opção válida.");
                    break;
            }

            Console.ReadKey();
        } while (selectMenu != 5);



        void RemoverMoeda()
        {
            if (cofrinho.RemoverMoeda(SelectMoeda()))
            {
                Console.WriteLine("Moeda removida com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor de moeda não encontrada. Tente novamente.");
            }

            Console.ReadKey();
        }
        Moeda SelectMoeda()
        {
            Moeda moeda = null;
            int selectMoeda = 0;

            do
            {

                Console.WriteLine("\n1. Real\n2. Dolar\n3. Euro");

                selectMoeda = int.Parse(Console.ReadLine());

                switch (selectMoeda)
                {
                    case 1:
                        moeda = new Real();
                        moeda.valor = selectValor();
                        break;
                    case 2:
                        moeda = new Dolar();
                        moeda.valor = selectValor();
                        break;
                    case 3:
                        moeda = new Euro();
                        moeda.valor = selectValor();
                        break;
                    default:
                        Console.WriteLine("\nPor favor escolha uma opção válida.");
                        break;
                }

            } while (moeda == null);

            return moeda;


            static double selectValor()
            {
                Console.WriteLine("\nDigite o valor desejado: \n");
                double selectValor = double.Parse(Console.ReadLine());

                return selectValor;
            }

        }
    }
}
