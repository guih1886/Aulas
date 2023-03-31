package com.mycompany.ex007;

/*

Exercicio de funcionarios, com os atributos de nome, sobrenome e salario mensal.

 */
public class Ex007 {

    public static void main(String[] args) {
        //instanciando os funcionarios
        Funcionario f1 = new Funcionario("Pedro", "Henrique", 2000);
        Funcionario f2 = new Funcionario("José", "Paulo", 2500);
        Funcionario f3 = new Funcionario("Márcia", "Cristina", 3850);

        //aplicando o aumento e mostrando o valor do salário anual.
        f1.setSalario(f1.getSalario() + f1.getSalario() * 0.10);
        System.out.println("Salario anual de " + f1.getPrimeiroNome() + " "
                + "" + f1.getSobrenome() + " é de: " + f1.getSalario() * 12);

        f2.setSalario(f2.getSalario() + f2.getSalario() * 0.10);
        System.out.println("Salario anual de " + f2.getPrimeiroNome() + " "
                + "" + f2.getSobrenome() + " é de: " + f2.getSalario() * 12);

        f3.setSalario(f3.getSalario() + f3.getSalario() * 0.10);
        System.out.println("Salario anual de " + f3.getPrimeiroNome() + " "
                + "" + f3.getSobrenome() + " é de: " + f3.getSalario() * 12);
    }
}
