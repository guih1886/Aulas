package br.com.alura.escola.academico.dominio.aluno;

import br.com.alura.escola.shared.dominio.CPF;
import br.com.alura.escola.academico.dominio.aluno.exceptions.NumeroDeTelefonesMaximosAtingidos;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertThrows;

public class AlunoTest {

    private Aluno aluno;

    @BeforeEach
    public void popular() {
        aluno = new Aluno(new CPF("123.456.789-00"), "Guilherme", new Email("guilherme@gmail.com"));
    }

    @Test
    public void deveriaCadastrarUmTelefone() {
        aluno.adicionarTelefone("19", "982210064");
        assertEquals(1, aluno.getTelefones().size());
    }

    @Test
    public void deveriaCadastrarDoisTelefones() {
        aluno.adicionarTelefone("19", "982210064");
        aluno.adicionarTelefone("19", "982210064");
        assertEquals(2, aluno.getTelefones().size());
    }

    @Test
    public void naoDeveriaDeixarCadastrarMaisQueDoisTelefones() {
        assertThrows(NumeroDeTelefonesMaximosAtingidos.class, () -> {
            aluno.adicionarTelefone("19", "982210064");
            aluno.adicionarTelefone("19", "982210064");
            aluno.adicionarTelefone("19", "982210064");
        });
    }
}
