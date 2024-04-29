using SistemaDeMusicas.Menus;
using SistemaDeMusicas.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {
        Banda Ira = new Banda("ira");
        Banda Beatles = new Banda("beatles");

        Ira.AdicionarNota(new Avaliacao(10));
        Ira.AdicionarNota(new Avaliacao(8));
        Ira.AdicionarNota(new Avaliacao(6));


        Dictionary<string, Banda> bandasRegistradas = new();
        bandasRegistradas.Add(Ira.Nome, Ira);
        bandasRegistradas.Add(Beatles.Nome, Beatles);

        void ExibirLogo()
        {
            Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
            Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
        }

        void ExibirOpcoesDoMenu()
        {
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
            Console.WriteLine("Digite 3 para mostrar todas as bandas");
            Console.WriteLine("Digite 4 para avaliar uma banda");
            Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    MenuRegistrarBanda menu1 = new MenuRegistrarBanda();
                    menu1.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case 2:
                    MenuRegistrarAlbum menu2 = new MenuRegistrarAlbum();
                    menu2.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case 3:
                    MenuMostrarBandasRegistradas menu3 = new MenuMostrarBandasRegistradas();
                    menu3.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case 4:
                    MenuAvaliarBanda menu4 = new MenuAvaliarBanda();
                    menu4.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case 5:
                    MenuExibirDetalhes menu5 = new MenuExibirDetalhes();
                    menu5.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case -1:
                    Console.WriteLine("Tchau tchau :)");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
                    ExibirOpcoesDoMenu();
            }
        }

        ExibirOpcoesDoMenu();
    }
}