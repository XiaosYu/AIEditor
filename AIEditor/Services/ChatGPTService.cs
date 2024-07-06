using AIEditor.Models;
using System.Net.Http.Json;
using System.Text.Json.Nodes;

public class ChatGPTService
{
    private static string ApiKey => "Bearer sk-m4svIBLCzZqZrrR41CJkqaSy1mDCkgrnVxGWu8E7mOVKm52B";
    private static string RequestAddress => "https://api.chatanywhere.com.cn/v1/chat/completions";
    private HttpClient Client { get; }
    public ChatGPTService()
    {
        Client = new HttpClient();
        Client.DefaultRequestHeaders.Add("Authorization", ApiKey);
        Client.DefaultRequestHeaders.Add("User-Agent", "Apifox/1.0.0 (https://apifox.com)");
    }

    public async Task<ChatToken?> Chat(string message, List<ChatToken> befores)
    {

        befores.Add(new ChatToken()
        {
            Content = message,
            Role = "user"
        });

        var bodyContent = new
        {
            body = "gpt-3.5-turbo",
            messages = befores
        };

        var result = await Client.PostAsJsonAsync(RequestAddress, bodyContent);
        if (result.IsSuccessStatusCode)
        {
            var content = await result.Content.ReadFromJsonAsync<JsonObject>();
            var token = new ChatToken()
            {
                Content = content["choices"].AsArray().Last()["message"]["content"].ToString(),
                Role = "assistant"
            };
            befores.Add(token);
            return token;
        }
        else return null;



    }
}