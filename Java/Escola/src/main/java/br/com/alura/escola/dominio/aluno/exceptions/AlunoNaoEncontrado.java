package br.com.alura.escola.dominio.aluno.exceptions;

import br.com.alura.escola.dominio.aluno.CPF;

public class AlunoNaoEncontrado extends RuntimeException {

    public AlunoNaoEncontrado(CPF cpf) {
        super("Aluno com o CPF " + cpf.getNumero() + " não encontrado.");
    }
}
