package br.com.alura.escola.gamificacao.infra.selo;

import br.com.alura.escola.shared.dominio.CPF;
import br.com.alura.escola.gamificacao.dominio.selo.Selo;
import br.com.alura.escola.gamificacao.dominio.selo.SeloRepository;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

public class RepositorioDeSeloH2 implements SeloRepository {

    private List<Selo> selos = new ArrayList<>();


    @Override
    public void adicionar(Selo selo) {
        this.selos.add(selo);
    }

    @Override
    public List<Selo> selosDoAlunoDeCPF(CPF cpf) {
        return this.selos.stream().filter(s -> s.getCpfDoAluno().equals(cpf.getNumero())).collect(Collectors.toList());
    }
}
