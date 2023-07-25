package br.com.alura.escola.academico.aplicacao.aluno.matricular;

import br.com.alura.escola.shared.dominio.evento.PublicadorDeEventos;
import br.com.alura.escola.academico.dominio.aluno.Aluno;
import br.com.alura.escola.academico.dominio.aluno.AlunoRepository;
import br.com.alura.escola.academico.dominio.aluno.AlunoMatriculado;

public class MatricularAluno {
    private final AlunoRepository repository;
    private final PublicadorDeEventos publicador;

    public MatricularAluno(AlunoRepository repository, PublicadorDeEventos publicador) {
        this.repository = repository;
        this.publicador = publicador;
    }

    public void matricular(MatricularAlunoDTO dados) {
        Aluno aluno = dados.criarAluno();
        repository.matricular(aluno);

        AlunoMatriculado evento = new AlunoMatriculado(aluno.getCpf());
        publicador.publicar(evento);
    }
}
