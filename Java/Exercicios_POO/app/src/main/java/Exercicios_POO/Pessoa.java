package Exercicios_POO;

public class Pessoa {

    private String nome;
    private float peso;
    private float altura;
    
    //construtor
    public Pessoa(float peso, float altura){
        this.peso = peso;
        this.altura = altura;
    }

    public float calcularIMC() {
        float imc = this.peso / (this.altura * this.altura);
        return imc;
    }

    public float getAltura() {
        return altura;
    }

    public String getNome() {
        return nome;
    }

    public float getPeso() {
        return peso;
    }

    public void setAltura(float altura) {
        this.altura = altura;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public void setPeso(float peso) {
        this.peso = peso;
    }
}
