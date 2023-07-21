package br.com.alura.escola.aplicacao.aluno.matricular;

import br.com.alura.escola.dominio.aluno.Aluno;
import br.com.alura.escola.dominio.aluno.CPF;
import br.com.alura.escola.infra.aluno.AlunoRepositoryH2;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

public class MatricularAlunoTest {

    @Test
    public void alunoDeveriaSerPersistido() {
        AlunoRepositoryH2 repositorio = new AlunoRepositoryH2();
        MatricularAluno useCase = new MatricularAluno(repositorio);
        MatricularAlunoDTO dados = new MatricularAlunoDTO("Guilherme", "123.456.789-00", "guilherme@gmail.com");
        useCase.matricular(dados);

        Aluno encontrado = repositorio.buscarPorCPF(new CPF("123.456.789-00"));

        assertEquals("Guilherme", encontrado.getNome());
        assertEquals("123.456.789-00", encontrado.getCpf());
        assertEquals("guilherme@gmail.com", encontrado.getEmail());
    }
}
