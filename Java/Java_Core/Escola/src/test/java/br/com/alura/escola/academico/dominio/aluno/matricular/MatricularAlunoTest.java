package br.com.alura.escola.academico.dominio.aluno.matricular;

import br.com.alura.escola.academico.aplicacao.aluno.matricular.MatricularAluno;
import br.com.alura.escola.academico.aplicacao.aluno.matricular.MatricularAlunoDTO;
import br.com.alura.escola.shared.dominio.evento.PublicadorDeEventos;
import br.com.alura.escola.academico.dominio.aluno.Aluno;
import br.com.alura.escola.shared.dominio.CPF;
import br.com.alura.escola.academico.dominio.aluno.LogDeAlunoMatriculado;
import br.com.alura.escola.academico.infra.aluno.AlunoRepositoryH2;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

public class MatricularAlunoTest {

    @Test
    public void alunoDeveriaSerPersistido() {
        AlunoRepositoryH2 repositorio = new AlunoRepositoryH2();
        PublicadorDeEventos publicador = new PublicadorDeEventos();
        publicador.adicionar(new LogDeAlunoMatriculado());

        MatricularAluno useCase = new MatricularAluno(repositorio, publicador);
        MatricularAlunoDTO dados = new MatricularAlunoDTO("Guilherme", "123.456.789-00", "guilherme@gmail.com");
        useCase.matricular(dados);

        Aluno encontrado = repositorio.buscarPorCPF(new CPF("123.456.789-00"));

        assertEquals("Guilherme", encontrado.getNome());
        assertEquals("123.456.789-00", encontrado.getCpf().toString() );
        assertEquals("guilherme@gmail.com", encontrado.getEmail());
    }
}
