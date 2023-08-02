package br.com.alura.screenmatch.principal;

import br.com.alura.screenmatch.modelos.Endereco;

import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

public class BuscadorDeCEP {
    public static void main(String[] args) throws IOException, InterruptedException {
        Scanner leitor = new Scanner(System.in);
        String cep = "";

        //buscando o CEP
        System.out.println("Inforome o CEP para buscar: ");
        cep = leitor.nextLine();
        BuscaCep buscaCep = new BuscaCep();
        Endereco json = buscaCep.buscarCep(cep);

        //armazenando o json em um arquivo
        GeradorDeArquivo gerador = new GeradorDeArquivo();
        gerador.gerarArquivoJson(json);    }
}
