package br.com.alura.escola.academico.dominio.aluno.exceptions;

public class NumeroDeTelefonesMaximosAtingidos extends IllegalArgumentException {

    public NumeroDeTelefonesMaximosAtingidos() {
        super("Número máximos de telefones já cadastrados.");
    }
}
