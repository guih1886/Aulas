package br.com.alura.escola.academico.infra.aluno;

import br.com.alura.escola.academico.dominio.aluno.Aluno;
import br.com.alura.escola.academico.dominio.aluno.AlunoRepository;
import br.com.alura.escola.shared.dominio.CPF;
import br.com.alura.escola.academico.dominio.aluno.exceptions.AlunoNaoEncontrado;

import java.util.ArrayList;
import java.util.List;

public class AlunoRepositoryH2 implements AlunoRepository {
    private List<Aluno> matriculados = new ArrayList<>();

    @Override
    public void matricular(Aluno aluno) {
        this.matriculados.add(aluno);
    }

    @Override
    public Aluno buscarPorCPF(CPF cpf) {
        return this.matriculados.stream().filter(aluno -> aluno.getCpf().toString().equals(cpf.getNumero())).findFirst().orElseThrow(() -> new AlunoNaoEncontrado(cpf));
    }

    public List<Aluno> listarTodosAlunosMatriculados() {
        return this.matriculados;
    }
}
