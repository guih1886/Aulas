package br.com.alura.escola.academico.infra.aluno;

import br.com.alura.escola.academico.dominio.aluno.*;
import br.com.alura.escola.academico.dominio.aluno.exceptions.AlunoNaoEncontrado;
import br.com.alura.escola.shared.dominio.CPF;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class AlunoRepositoryJDBC implements AlunoRepository {

    private Connection connection;

    public AlunoRepositoryJDBC(Connection connection) {
        this.connection = connection;
    }

    @Override
    public void matricular(Aluno aluno) {
        try {
            String sql = "INSERT INTO ALUNO VALUES (?,?,?)";
            PreparedStatement ps = connection.prepareStatement(sql);
            String cpfString = aluno.getCpf().toString();
            ps.setString(1, cpfString);
            ps.setString(2, aluno.getNome());
            ps.setString(3, aluno.getEmail());
            ps.execute();

            sql = "INSERT INTO TELEFONE VALUES(?,?)";
            ps = connection.prepareStatement(sql);
            for (Telefone telefone : aluno.getTelefones()) {
                ps.setString(1, telefone.getDdd());
                ps.setString(2, telefone.getNumero());
            }
            ps.execute();
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }

    @Override
    public Aluno buscarPorCPF(CPF cpf) {
        try {
            String sql = "SELECT * FROM ALUNO WHERE CPF = ?";
            PreparedStatement ps = connection.prepareStatement(sql);
            ps.setString(1, cpf.getNumero());

            ResultSet rs = ps.executeQuery();
            boolean encontrou = rs.next();
            if (!encontrou) {
                throw new AlunoNaoEncontrado(cpf);
            }
            String nome = rs.getString("nome");
            Email email = new Email(rs.getNString("email"));
            Aluno encontrado = new Aluno(cpf, nome, email);

            Long id = rs.getLong("id");
            sql = "SELECT ddd, numero FROM TELEFONE WHERE aluno_id = ?";
            ps = connection.prepareStatement(sql);
            ps.setLong(1, id);
            rs = ps.executeQuery();
            while (rs.next()) {
                String numero = rs.getString("numero");
                String ddd = rs.getString("ddd");
                encontrado.adicionarTelefone(ddd, numero);
            }
            return encontrado;
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
}
