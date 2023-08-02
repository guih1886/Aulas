package br.com.alura.escola.academico.dominio.aluno;

import br.com.alura.escola.shared.dominio.evento.Ouvinte;
import br.com.alura.escola.shared.dominio.evento.Evento;

import java.time.format.DateTimeFormatter;

public class LogDeAlunoMatriculado extends Ouvinte {

    public void reageAo(Evento evento) {
        String dataFormatada = evento.momento().format(DateTimeFormatter.ofPattern("dd/MM/yyyy HH:mm"));
        System.out.println(String.format("Aluno com o CPF %s matriculado em: %s", ((AlunoMatriculado) evento).getCpfDoAluno(), dataFormatada));
    }

    @Override
    protected boolean deveProcessar(Evento evento) {
        return evento instanceof AlunoMatriculado;
    }
}
