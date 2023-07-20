package br.com.alura.escola;

public class Email {

    //value object, pois não tem identificador único
    private String endereco;

    public Email(String email) {
        if (email == null || !email.matches("^[a-zA-Z0-9._]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$")) {
            throw new IllegalArgumentException("E-mail inválido.");
        }
        this.endereco = email;
    }

    public String getEndereco() {
        return endereco;
    }
}
