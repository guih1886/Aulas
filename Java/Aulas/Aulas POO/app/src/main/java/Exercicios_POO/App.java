package Exercicios_POO;

import java.util.Date;
import java.util.Scanner;

public class App {

    public static void main(String[] args) {
        /*        
        //construtor executa na instancia do objeto
        Pessoa objPessoa = new Pessoa(10, 20);
        Scanner leitor = new Scanner(System.in);
        
        System.out.print("Digite seu nome: ");
        objPessoa.setNome(leitor.nextLine());
        
        System.out.print("Digite seu peso: ");
        objPessoa.setPeso(leitor.nextFloat());
        
        System.out.print("Digite sua altura: ");
        objPessoa.setAltura(leitor.nextFloat());
        
        System.out.print("O IMC de " + objPessoa.getNome() + " é de: " + objPessoa.
                calcularIMC());
         */
        
        
        //instanciando um vendedor por herança
        Vendedor v = new Vendedor();
        v.setNome("José");
        v.setCPF("3465326");
        v.setDataNasc(new Date());
        v.setSalario(3000.0f);
        v.setComissaoPorItem(10.0f);
        v.setTotalItensVendidos(50);
        
        System.out.print("Salario do vendedor: "+ v.calcularSalario());
    }
}
