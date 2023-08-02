package br.com.alura.screenmatch.principal;

import br.com.alura.screenmatch.modelos.Endereco;
import com.google.gson.Gson;

import java.io.IOException;
import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;

public class BuscaCep {

    public Endereco buscarCep(String cep) throws IOException, InterruptedException {
        URI endereco = URI.create("https://viacep.com.br/ws/" + cep + "/json");

        HttpClient cliente = HttpClient.newHttpClient();
        HttpRequest request = HttpRequest.newBuilder().uri(endereco).build();
        HttpResponse<String> response = cliente.send(request, HttpResponse.BodyHandlers.ofString());
        return new Gson().fromJson(response.body(), Endereco.class);
    }
}
