package br.com.alura.escola.gamificacao.aplicacao;

import br.com.alura.escola.gamificacao.dominio.selo.Selo;
import br.com.alura.escola.gamificacao.dominio.selo.SeloRepository;
import br.com.alura.escola.shared.dominio.CPF;
import br.com.alura.escola.shared.dominio.evento.Ouvinte;
import br.com.alura.escola.shared.dominio.evento.Evento;
import br.com.alura.escola.shared.dominio.evento.TipoEvento;

public class GeraSeloNovato extends Ouvinte {
    private SeloRepository repositorioDeSelos;

    public GeraSeloNovato(SeloRepository repositorioDeSelos) {
        this.repositorioDeSelos = repositorioDeSelos;
    }

    @Override
    protected void reageAo(Evento evento) {
        CPF cpfDoAluno = (CPF) evento.informacoes().get("cpf");
        Selo novato = new Selo(cpfDoAluno, "Selo de Novato");
        repositorioDeSelos.adicionar(novato);
    }

    @Override
    protected boolean deveProcessar(Evento evento) {
        return evento.tipo() == TipoEvento.ALUNO_MATRICULADO;
    }
}
