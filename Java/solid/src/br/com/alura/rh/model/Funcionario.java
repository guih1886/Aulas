package br.com.alura.rh.model;

import java.math.BigDecimal;
import java.time.LocalDate;

import br.com.alura.rh.ValidacaoException;

public class Funcionario extends DadosPessoais {


    private LocalDate dataUltimoReajuste;

    public Funcionario(String nome, String cpf, Cargo cargo, BigDecimal salario) {
        super(nome, cpf, cargo, salario);
    }

    public void atualizaSalario(BigDecimal aumento) {
        setSalario(aumento);
        this.dataUltimoReajuste = LocalDate.now();
    }


    public LocalDate getDataUltimoReajuste() {
        return dataUltimoReajuste;
    }

    public void promover(Cargo cargoNovo) {
        setCargo(cargoNovo);
    }
}
