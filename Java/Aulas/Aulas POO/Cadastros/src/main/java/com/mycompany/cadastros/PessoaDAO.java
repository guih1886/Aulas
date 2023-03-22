package com.mycompany.cadastros;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

public class PessoaDAO extends DAO {

    public void incluirPessoa(Pessoa p) throws Exception {
        open();
        PreparedStatement insertStmt = conexao.prepareStatement(
                "insert into cadastrodepessoas values (?,?,?,?)");
        insertStmt.setInt(1, p.getId());
        insertStmt.setString(2, p.getNome());
        insertStmt.setString(3, p.getEmail());
        insertStmt.setString(4, p.getPhone());
        insertStmt.execute();
        insertStmt.close();
        close();
    }

    public void alterarPessoa(Pessoa p) throws Exception {
        open();
        PreparedStatement insertStmt = conexao.prepareStatement(
                "update cadastrodepessoas set "
                + "name = ?, email = ?, phone = ? where id = ?");
        insertStmt.setString(1, p.getNome());
        insertStmt.setString(2, p.getEmail());
        insertStmt.setString(3, p.getPhone());
        insertStmt.setInt(4, p.getId());
        insertStmt.execute();
        insertStmt.close();
        close();
    }

    public void excluirPessoa(Pessoa p) throws Exception {
        open();
        PreparedStatement insertStmt = conexao.prepareStatement(
                "delete from cadastrodepessoas where id = ?");
        insertStmt.setInt(1, p.getId());
        insertStmt.execute();
        insertStmt.close();
        close();
    }

    //retorna um objeto
    public Pessoa consultarPessoaIndividual(int cod) throws Exception {
        open();
        ResultSet rs = null;
        PreparedStatement insertStmt = conexao.prepareStatement(
                "select * from cadastrodepessoas where id = ?");
        insertStmt.setInt(1, cod);
        try {
            rs = insertStmt.executeQuery();
        } catch (SQLException e) {
            throw new Exception(e);
        }

        Pessoa p = new Pessoa();
        if (rs != null) {
            if (rs.next()) {
                p.setId(rs.getInt("id"));
                p.setNome(rs.getString("name"));
                p.setEmail(rs.getString("email"));
                p.setPhone(rs.getString("phone"));
            }
        }
        close();
        return p;
    }

    public List<Pessoa> listarPessoas() {
        try {
            open();
            PreparedStatement insertStmt = conexao.prepareStatement(
                    "select * from cadastrodepessoas");
            ResultSet rs = insertStmt.executeQuery();
            List<Pessoa> listaPessoas = new ArrayList<>();
            while (rs.next()) {
                Pessoa p = new Pessoa();
                p.setId(rs.getInt("id"));
                p.setNome(rs.getString("name"));
                p.setEmail(rs.getString("email"));
                p.setPhone(rs.getString("phone"));
                listaPessoas.add(p);
            }
            insertStmt.close();
            rs.close();
            insertStmt.close();
            close();
            return listaPessoas;
        } catch (Exception e) {
            System.out.println("Erro em " + e);
            return null;
        }
    }
}
