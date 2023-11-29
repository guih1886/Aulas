using ScreenSound.Menus;
using ScreenSound.Modelos;
using OpenAI_API;



Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuExibirDetalhes());
opcoes.Add(6, new MenuAvaliarAlbum());
opcoes.Add(-1, new MenuSair());

if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
{
    Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
    menuASerExibido.Executar();
}
else
{
    Console.WriteLine("Opção inválida.");
}

