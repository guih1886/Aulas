package br.com.alura.screenmatch.modelos;

public record Endereco(String cep, String logradouro, String complemento, String bairro, String localidade, String uf) {

    @Override
    public String toString() {
        return "Endereco {\n" +
                "cep = " + cep + "\n" +
                ", logradouro='" + logradouro + '\n' +
                ", complemento='" + complemento + '\n' +
                ", bairro='" + bairro + '\n' +
                ", localidade='" + localidade + '\n' +
                ", uf='" + uf + '\n' +
                '}';
    }
}
