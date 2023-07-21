package br.com.alura.escola;

import static org.junit.jupiter.api.Assertions.*;

import br.com.alura.escola.dominio.aluno.Email;
import org.junit.jupiter.api.Test;

public class EmailTest {

    @Test
    public void naoDeveriaCriarEmailComEnderecosInvalidos() {
        assertThrows(IllegalArgumentException.class, () -> new Email(null));
        assertThrows(IllegalArgumentException.class, () -> new Email(""));
        assertThrows(IllegalArgumentException.class, () -> new Email("emailinvalido"));
    }

    @Test
    public void deveriaCriarEmailComEnderecoValido() {
        Email email = new Email("guilherme@gmail.com");
        assertEquals("guilherme@gmail.com", email.getEndereco());
    }
}
