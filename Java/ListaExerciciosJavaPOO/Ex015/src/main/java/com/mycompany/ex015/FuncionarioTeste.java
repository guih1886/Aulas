package com.mycompany.ex015;

/**
 * Exercicio do funcionario, aonde é possivel dar um aumento pra ele e exibir o
 * valor do salario anual. Tem também um contador aonde é possivel vizualizar
 * quantos funcionário já passaram pela empresa.
 */
public class FuncionarioTeste {

    public static void main(String[] args) {
        //instanciando os funcionarios
        Funcionario fun1 = new Funcionario("Pedro", "Henrique", 1580);
        Funcionario fun2 = new Funcionario("José", "Pedro", 1300.99);
        Funcionario fun3 = new Funcionario("Paulo", "Cardoso", 2000);
        Funcionario fun4 = new Funcionario("Beatriz", "Maria", 3850);

        //dando aumento aos funcionarios
        fun1.aumentarSalario(10);
        fun2.aumentarSalario(10);
        fun3.aumentarSalario(10);
        fun4.aumentarSalario(10);

        //mostrando quantos funcionários teve a empresa
        System.out.println("Passaram pela empresa "+Funcionario.passaramPelaEmpresa+" funcionários até hoje.");

    }
}
