package br.com.alura.screenmatch.exceptions;

public class ErroDeAnoDoFilme extends RuntimeException {
    private String mensagem;
    public ErroDeAnoDoFilme(String mensagem) {
        this.mensagem = mensagem;
    }

    public String getMesagem() {
        return this.mensagem;
    }
}
