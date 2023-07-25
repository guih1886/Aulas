package br.com.alura.escola.academico.dominio.aluno;

import br.com.alura.escola.shared.dominio.CPF;

public interface AlunoRepository {

    void matricular(Aluno aluno);

    Aluno buscarPorCPF(CPF cpf);

}
