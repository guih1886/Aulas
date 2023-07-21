package br.com.alura;

import br.com.alura.escola.aplicacao.aluno.matricular.MatricularAluno;
import br.com.alura.escola.aplicacao.aluno.matricular.MatricularAlunoDTO;
import br.com.alura.escola.infra.aluno.AlunoRepositoryH2;

public class Main {
    public static void main(String[] args) {
        String nome = "Guilherme Henrique";
        String cpf = "123.456.789-00";
        String email = "guilherme_18henrique@yahoo.com.br";

        MatricularAluno aluno = new MatricularAluno(new AlunoRepositoryH2());
        aluno.matricular(new MatricularAlunoDTO(nome, cpf, email));
    }
}