internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("COFRINHO DA DANI");
        Console.WriteLine("Por favor digite a opção desejada:");

        int selectMenu;

        do
        {
            Console.WriteLine("1. Adicionar moeda\n2. Remover moeda\n3.Listar moedas no cofrinho\n4. Consultar valor total em reais\n5. Encerrar");
            selectMenu = int.Parse(Console.ReadLine());

            switch (selectMenu)
            {
                case 1:
                    // adicionar moeda
                    break;
                case 2:
                    // remover moeda
                    break;
                case 3:
                    // listar moeda
                    break;
                case 4:
                    // consultar valor total em reais
                    break;
                case 5:
                    Console.WriteLine("\nEncerrando... Sistema finalizado.");
                    break;
                default:
                    Console.WriteLine("\nPor favor escolha uma opção válida.");
                    break;
            }

        } while (selectMenu != 5);
    }
}