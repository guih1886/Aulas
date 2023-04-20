package com.mycompany.ex017;

import java.util.Scanner;

public class GerenciadorTarefas {

    private int opcao = 0;
    private int opcaoCadastrar = 0;
    Scanner leitor = new Scanner(System.in);

    public void iniciar() {
        System.out.println("------- Sistema gerenciador de tarefas ---------");
        System.out.println("1 - Cadastrar | 2 - Remover | 3 - Consultar");
        System.out.print("Digite sua opção: ");
        this.opcao = leitor.nextInt();
        switch (this.opcao) {
            case 1:
                cadastrar();
                break;
            case 2:
                remover();
                break;
            case 3:
                consultar();
                break;
            default:
                System.out.println("inv");
                break;
        }

    }

    public void cadastrar() {
        System.out.println("------------ Cadastrar tarefas -------------");
        System.out.println("1 - Reuniões | 2 - Pagamentos | 3 - Entrega de "
                + "Projetos | 4 - Voltar");
        System.out.print("Digite sua opção: ");
        this.opcaoCadastrar = leitor.nextInt();
        switch (this.opcaoCadastrar) {
            case 1:
                int id = 1;
                String nome;
                String data;
                String nomeConvidado;
                String telefone;
                System.out.print("Digite o nome do participante: ");
                nome = leitor.next();
                System.out.print("Digite data de nascimento do participante: ");
                data = leitor.next();
                System.out.print("Digite o nome do convidado: ");
                nomeConvidado = leitor.next();
                System.out.print("Digite o telefone do convidado: ");
                telefone = leitor.next();
                Reuniao r1 = new Reuniao(id, nome, data, nomeConvidado, telefone);
                break;
            case 2:
                //
                break;
            case 3:
                //
                break;
            case 4:
                iniciar();
                break;
            default:
                System.out.println("inv");
                break;
        }
    }

    public void remover() {
        System.out.println("remover");
    }

    public void consultar() {
        System.out.println("consultar");
    }
}
