package com.mycompany.generics;

public class Aeronave<T> {
     private T nome;
     private T numeroAeronave;

    public Aeronave(T nome, T numeroAeronave) {
        this.nome = nome;
        this.numeroAeronave = numeroAeronave;
    }

    public T getNome() {
        return nome;
    }

    public void setNome(T nome) {
        this.nome = nome;
    }

    public T getNumeroAeronave() {
        return numeroAeronave;
    }

    public void setNumeroAeronave(T numeroAeronave) {
        this.numeroAeronave = numeroAeronave;
    }
    
    @Deprecated
    public String deprecated(){
        return "Método marcado como deprecated.";
    }
    
     
}
