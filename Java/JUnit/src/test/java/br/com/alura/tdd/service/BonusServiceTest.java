package br.com.alura.tdd.service;

import br.com.alura.tdd.modelo.Funcionario;
import org.junit.jupiter.api.Test;

import java.math.BigDecimal;
import java.time.LocalDate;

import static org.junit.jupiter.api.Assertions.assertEquals;


public class BonusServiceTest {

    @Test
    public void bonusDeveriaSerZeroParaBonusMaiorQueMil() {
        BonusService service = new BonusService();
        BigDecimal bonus = service.calcularBonus(new Funcionario("Guilherme", LocalDate.now(), new BigDecimal("20000")));
        assertEquals(new BigDecimal("0.00"), bonus);
    }

    @Test
    public void deveriaSerDezPorcentoDoSalario() {
        BonusService service = new BonusService();
        BigDecimal bonus = service.calcularBonus(new Funcionario("Guilherme", LocalDate.now(), new BigDecimal("2500")));
        assertEquals(new BigDecimal("250.00"), bonus);
    }
}
