package br.com.alura.escola;

import static org.junit.jupiter.api.Assertions.*;

import br.com.alura.escola.dominio.aluno.CPF;
import org.junit.jupiter.api.Test;

public class CPFTest {

    @Test
    public void naoDeveriaCriarCPFComNumeroInvalido() {
        assertThrows(IllegalArgumentException.class, () -> new CPF(null));
        assertThrows(IllegalArgumentException.class, () -> new CPF(""));
        assertThrows(IllegalArgumentException.class, () -> new CPF("12349986"));
    }

    @Test
    public void deveriaCriarCPFComNumeroValido() {
        CPF cpf = new CPF("123.456.789-00");
        assertEquals("123.456.789-00", cpf.getNumero());
    }
}
