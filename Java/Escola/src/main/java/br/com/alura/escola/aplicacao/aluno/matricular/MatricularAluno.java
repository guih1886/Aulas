package br.com.alura.escola.aplicacao.aluno.matricular;

import br.com.alura.escola.dominio.aluno.Aluno;
import br.com.alura.escola.dominio.aluno.AlunoRepository;

public class MatricularAluno {
    private final AlunoRepository repository;

    public MatricularAluno(AlunoRepository repository) {
        this.repository = repository;
    }

    public void matricular(MatricularAlunoDTO dados) {
        Aluno aluno = dados.criarAluno();
        repository.matricular(aluno);
    }
}
