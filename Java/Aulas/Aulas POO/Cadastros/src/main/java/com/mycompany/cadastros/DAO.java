package com.mycompany.cadastros;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class DAO {

    String url = "jdbc:mysql://localhost:3306/cadastroDePessoas";
    String usuario = "root";
    String senha = "";
    Connection conexao = null;

    public void open() throws ClassNotFoundException {
        try {
            conexao = DriverManager.getConnection(url, usuario, senha);
            System.out.println("Conexão efetuada com sucesso.");
        } catch (SQLException e) {
            System.out.println("Erro ao conectar ao banco de dados: " + e.getMessage());
        }
    }

    public void close() {
        try {
            if (conexao != null) {
                conexao.close();
            }
        } catch (SQLException e) {
            System.out.println("Erro ao fechar a conexão com o banco de dados: " + e.getMessage());
        }

    }
}
