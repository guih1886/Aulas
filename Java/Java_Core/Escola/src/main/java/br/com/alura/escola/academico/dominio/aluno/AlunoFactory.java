package br.com.alura.escola.academico.dominio.aluno;

import br.com.alura.escola.shared.dominio.CPF;

public class AlunoFactory {

    private Aluno aluno;

    public AlunoFactory criarComNomeCPFEmail(String nome, String CPF, String email) {
        this.aluno = new Aluno(new CPF(CPF), nome, new Email(email));
        return this;
    }

    public AlunoFactory criarTelefone(String ddd, String numero) {
        this.aluno.adicionarTelefone(ddd, numero);
        return this;
    }

    public Aluno criar() {
        return this.aluno;
    }
}
