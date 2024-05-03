using SistemaDeMusicas.Modelos;

namespace SistemaDeMusicas.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Encerrando programa...");
        Thread.Sleep(1000);
    }
}
