package br.com.alura.escola.academico.dominio.aluno;

import br.com.alura.escola.shared.dominio.evento.Evento;
import br.com.alura.escola.shared.dominio.CPF;
import br.com.alura.escola.shared.dominio.evento.TipoEvento;

import java.time.LocalDateTime;
import java.util.Map;

public class AlunoMatriculado implements Evento {

    private final CPF cpfDoAluno;
    private final LocalDateTime momento;

    public AlunoMatriculado(CPF cpfDoAluno) {
        this.cpfDoAluno = cpfDoAluno;
        this.momento = LocalDateTime.now();
    }

    @Override
    public LocalDateTime momento() {
        return this.momento;
    }

    @Override
    public TipoEvento tipo() {
        return TipoEvento.ALUNO_MATRICULADO;
    }

    @Override
    public Map<String, Object> informacoes() {
        return Map.of("cpf", this.cpfDoAluno);
    }

    public CPF getCpfDoAluno() {
        return this.cpfDoAluno;
    }
}
