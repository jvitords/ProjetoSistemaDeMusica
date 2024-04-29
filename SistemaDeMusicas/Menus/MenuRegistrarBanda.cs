using SistemaDeMusicas.Modelos;

namespace SistemaDeMusicas.Menus;

internal class MenuRegistrarBanda : Menu
{
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        MenuExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine("Digite uma tecla para votar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
