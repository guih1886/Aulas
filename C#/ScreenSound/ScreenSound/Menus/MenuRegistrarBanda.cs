using OpenAI_API;
using ScreenSound.Menus;
using ScreenSound.Modelos;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        //integração com o chatgpt
        var client = new OpenAIAPI("chave");
        var chat = client.Chat.CreateConversation();
        chat.AppendSystemMessage("");
        string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
    }
}