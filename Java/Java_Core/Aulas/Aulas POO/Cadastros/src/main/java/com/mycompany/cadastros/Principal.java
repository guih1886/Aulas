package com.mycompany.cadastros;

import java.util.List;

public class Principal {

    public static void main(String[] args) throws Exception {
        PessoaDAO pd = new PessoaDAO();
        // inclusao de pessoas CERTO
        /*
        Pessoa p1 = new Pessoa(1, "Guilherme Henrique", "sememail@gmail.com", "19982210064");
        Pessoa p2 = new Pessoa(2, "José da Silva", "3598715293");
        pd.incluirPessoa(p1);
        pd.incluirPessoa(p2);
        Pessoa p3 = new Pessoa("João Pedro", "joazinho@hotmail.com", "328224652");
        pd.incluirPessoa(p3);
         */

        //alterando uma pessoa
        Pessoa pes = pd.consultarPessoaIndividual(2);
        if (pes != null) {
            pes.setEmail("emaildojose2@gmail.com");
            pd.alterarPessoa(pes);
        } else {
            System.out.println("Pessoa não encontrada.");
        }
        /*
        //listando as pessoas
        List<Pessoa> listaPessoa = pd.listarPessoas();
        for (Pessoa p : listaPessoa) {
            System.out.println("Id: " + p.getId());
            System.out.println("Nome: " + p.getNome());
            System.out.println("E-mail: " + p.getEmail());
            System.out.println("Telefone: " + p.getPhone());
            System.out.println("---------------------");
        }
         */

    }
}
