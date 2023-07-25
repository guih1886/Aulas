package br.com.alura.escola.academico.dominio.aluno.exceptions;

import br.com.alura.escola.shared.dominio.CPF;

public class AlunoNaoEncontrado extends IllegalArgumentException {

    public AlunoNaoEncontrado(CPF cpf) {
        super("Aluno com o CPF " + cpf.getNumero() + " não encontrado.");
    }
}
