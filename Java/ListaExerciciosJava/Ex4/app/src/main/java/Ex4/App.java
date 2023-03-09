package Ex4;

import java.util.Scanner;

public class App {

    public static void main(String[] args) {
        String nomeVendedor;
        float salario;
        float totalVenda;
        float salarioMes = 0.0f;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Digite o nome do vendedor: ");
        nomeVendedor = leitor.next();
        System.out.print("Digite o salario do vendedor: ");
        salario = leitor.nextFloat();
        System.out.print("Digite o total de vendas do vendedor: ");
        totalVenda = leitor.nextFloat();
        
        salarioMes = (float) (salario + (totalVenda * 0.15));
        
        System.out.print(nomeVendedor + ": salario fixo - " + salario + 
                " | salario do mes: "+ salarioMes);        
    }
}
