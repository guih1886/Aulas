package br.com.alura.escola.academico.dominio.aluno;

import br.com.alura.escola.academico.dominio.aluno.Telefone;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

public class TelefoneTest {

    @Test
    public void naoDeveriaCriarTelefoneComNumeroInvalido() {
        assertThrows(IllegalArgumentException.class, () -> new Telefone(null, null));
        assertThrows(IllegalArgumentException.class, () -> new Telefone("", ""));
        assertThrows(IllegalArgumentException.class, () -> new Telefone("123", null));
        assertThrows(IllegalArgumentException.class, () -> new Telefone("1365", "1326549"));
    }

    @Test
    public void deveriaCriarTelefoneComNumeroValido() {
        Telefone telefone = new Telefone("19", "982210064");
        assertEquals("19", telefone.getDdd());
        assertEquals("982210064", telefone.getNumero());
    }
}
