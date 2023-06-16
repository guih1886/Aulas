package br.com.alura.screenmatch.principal;

import br.com.alura.screenmatch.exceptions.ErroDeAnoDoFilme;
import br.com.alura.screenmatch.modelos.Titulo;
import br.com.alura.screenmatch.modelos.TituloOmdb;
import com.google.gson.FieldNamingPolicy;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class PrincipalComBusca {
    public static void main(String[] args) throws IOException, InterruptedException {
        ;
        var busca = "";
        var chave = "a0a9afbb";
        List<Titulo> lista = new ArrayList<>();
        Gson gson = new GsonBuilder().setFieldNamingPolicy(FieldNamingPolicy.UPPER_CAMEL_CASE).setPrettyPrinting().create();

        while (!busca.equalsIgnoreCase("sair")) {

            Scanner leitor = new Scanner(System.in);
            System.out.println("Digite um filme para a busca: ");
            busca = leitor.nextLine().replace(" ", "%20");
            var endereco = "http://www.omdbapi.com/?t=" + busca + "&apikey=" + chave;

            if (busca.equalsIgnoreCase("sair")) break;

            HttpClient cliente = HttpClient.newHttpClient();
            HttpRequest request = HttpRequest.newBuilder().uri(URI.create(endereco)).build();

            HttpResponse<String> response = cliente.send(request, HttpResponse.BodyHandlers.ofString());
            String json = response.body();
            System.out.println(json);

            TituloOmdb meuTituloOmdb = gson.fromJson(json, TituloOmdb.class);
            System.out.println("Meu tituloOmbd: " + meuTituloOmdb);
            try {
                Titulo meuTitulo = new Titulo(meuTituloOmdb);
                System.out.println("Meu titulo: " + meuTitulo);
                lista.add(meuTitulo);
                System.out.println(lista);
            } catch (ErroDeAnoDoFilme e) {
                System.out.println(e.getMesagem());
            }
        }
//        File file = new File("C:\\filmes.json");
        FileWriter escrita = new FileWriter("filmes.json");
        escrita.write(gson.toJson(lista));
        escrita.close();
    }
}
