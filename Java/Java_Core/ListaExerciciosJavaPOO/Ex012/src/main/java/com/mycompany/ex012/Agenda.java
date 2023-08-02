package com.mycompany.ex012;

public class Agenda {

    private String[] agenda = new String[3];
    private String[] nome = new String[3];
    private int[] idade = new int[3];
    private float[] altura = new float[3];

    public void armazenarPessoa(String nome, int idade, float altura) {
        //verifica se o index de agenda está vazio para armazenar a pessoa
        for (int i = 0; i < this.agenda.length; i++) {
            if (this.agenda[i] == null) {
                this.agenda[i] = String.valueOf(i);
                this.nome[i] = nome;
                this.idade[i] = idade;
                this.altura[i] = altura;
                System.out.println("Pessoa " + i + " adicionada com sucesso.");
                return;
            }
        }
        System.out.println("Sem espaços na agenda disponíveis.");
    }

    public void removerPessoa(String nome) {
        //verifica se tem o nome no array, e se sim retira
        for (int i = 0; i < this.nome.length; i++) {
            if (this.nome[i] == nome) {
                this.agenda[i] = null;
                this.nome[i] = "";
                this.idade[i] = 0;
                this.altura[i] = 0.0f;
                System.out.println(nome + " foi removido com sucesso.");
                return;
            }
        }
        System.out.println("Pessoa não está na agenda.");
    }

    public void buscarPessoa(String nome) {
        //verifica se tem o nome no array, e se sim informa o index
        for (int i = 0; i < this.nome.length; i++) {
            if (this.nome[i] == nome) {
                System.out.println("Pessoa está na posição: " + (i + 1));
                break;
            } else {
                System.out.println("Pessoa não está na agenda.");
                break;
            }
        }
    }

    public void imprimirPessoa(int index) {
        //verifica se tem alguem na posição do index
        if (index >= this.agenda.length) {
            System.out.println("Index maior que as posições da agenda, "
                    + "informe um valor até " + (this.agenda.length - 1));
        } else if (this.agenda[index] == null) {
            System.out.println("Não tem pessoa nessa posição!");
        } else {
            System.out.println(index + " - Nome: " + this.nome[index] + " | "
                    + "Idade: " + this.idade[index] + " | "
                    + "Altura: " + this.altura[index]);
        }
    }

    public void imprimirAgenda() {
        for (int i = 0; i < this.agenda.length; i++) {
            imprimirPessoa(i);
        }
    }
}
