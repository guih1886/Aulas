package br.com.alura.tdd.service;

import br.com.alura.tdd.modelo.Funcionario;
import org.junit.jupiter.api.Test;

import java.math.BigDecimal;
import java.time.LocalDate;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class ReajusteServiceTest {
    @Test
    public void reajusteDeveriaSerTresPorcentoParaDesempenhoADesejar() {
        ReajusteService service = new ReajusteService();
        Funcionario funcionario = new Funcionario("Guilherme", LocalDate.now(), new BigDecimal("1000.00"));
        service.reajustar(funcionario, Desempenho.A_DESEJAR);
        BigDecimal novoSalario = funcionario.getSalario();
        assertEquals(new BigDecimal("1030.00"), novoSalario);
    }

    @Test
    public void reajusteDeveriaSerQuinzePorcentoParaDesempenhoBom() {
        ReajusteService service = new ReajusteService();
        Funcionario funcionario = new Funcionario("Guilherme", LocalDate.now(), new BigDecimal("1000.00"));
        service.reajustar(funcionario, Desempenho.BOM);
        BigDecimal novoSalario = funcionario.getSalario();
        assertEquals(new BigDecimal("1150.00"), novoSalario);
    }

    @Test
    public void reajusteDeveriaSerVintePorcentoParaDesempenhoOtimo() {
        ReajusteService service = new ReajusteService();
        Funcionario funcionario = new Funcionario("Guilherme", LocalDate.now(), new BigDecimal("1000.00"));
        service.reajustar(funcionario, Desempenho.OTIMO);
        BigDecimal novoSalario = funcionario.getSalario();
        assertEquals(new BigDecimal("1200.00"), novoSalario);
    }
}
