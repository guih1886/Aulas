package br.com.alura.escola;

import br.com.alura.escola.academico.aplicacao.aluno.matricular.MatricularAluno;
import br.com.alura.escola.academico.aplicacao.aluno.matricular.MatricularAlunoDTO;
import br.com.alura.escola.shared.dominio.evento.PublicadorDeEventos;
import br.com.alura.escola.academico.dominio.aluno.LogDeAlunoMatriculado;
import br.com.alura.escola.academico.infra.aluno.AlunoRepositoryH2;

public class Main {
    public static void main(String[] args) {
        String nome = "Guilherme Henrique";
        String cpf = "123.456.789-00";
        String email = "guilherme_18henrique@yahoo.com.br";

        PublicadorDeEventos publicador = new PublicadorDeEventos();
        publicador.adicionar(new LogDeAlunoMatriculado());

        MatricularAluno aluno = new MatricularAluno(new AlunoRepositoryH2(), publicador);
        aluno.matricular(new MatricularAlunoDTO(nome, cpf, email));
    }
}