package com.mycompany.cadastros;

public class Pessoa {

    private int id;
    private String nome;
    private String email;
    private String phone;

    public Pessoa() {
    }

    public Pessoa(String nome, String email, String phone) {
        this.nome = nome;
        this.email = email;
        this.phone = phone;
    }

    public Pessoa(int id, String nome, String phone) {
        this.id = id;
        this.nome = nome;
        this.phone = phone;
    }

    public Pessoa(int id, String nome, String email, String phone) {
        this.id = id;
        this.nome = nome;
        this.email = email;
        this.phone = phone;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getPhone() {
        return phone;
    }

    public void setPhone(String phone) {
        this.phone = phone;
    }

}
