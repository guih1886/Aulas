package br.com.alura.screenmatch.principal;

import br.com.alura.screenmatch.modelos.Endereco;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import java.io.FileWriter;
import java.io.IOException;

public class GeradorDeArquivo {

    public void gerarArquivoJson(Endereco endereco) {
        try {
            Gson gson = new GsonBuilder().setPrettyPrinting().create();
            FileWriter arquivo = new FileWriter(endereco.cep() + ".json");
            arquivo.write(gson.toJson(endereco, Endereco.class));
            arquivo.close();
            System.out.println("Arquivo criado com sucesso!");
        } catch (IOException e) {
            throw new RuntimeException(e);
        }

    }
}
