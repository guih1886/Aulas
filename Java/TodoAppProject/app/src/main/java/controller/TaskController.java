package controller;

import java.sql.Connection;
import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import model.Task;
import util.ConnectionFactory;

public class TaskController {

    public void save(Task task) {
        String sql = "INSERT INTO tasks (id_project,"
                + "name,"
                + "description,"
                + "completed,"
                + "notes,"
                + "deadline,"
                + "createdAt,"
                + "updatedAt) VALUES (?,?,?,?,?,?,?,?)";
        Connection conn = null;
        PreparedStatement statement = null;

        try {
            conn = ConnectionFactory.getConnection();
            statement = conn.prepareStatement(sql);
            statement.setInt(1, task.getId_project());
            statement.setString(2, task.getName());
            statement.setString(3, task.getDescription());
            statement.setBoolean(4, task.getCompleted());
            statement.setString(5, task.getNotes());
            statement.setDate(6, new Date(task.getDeadline().
                    getTime()));
            statement.setDate(7, new Date(task.getCreatedAt().
                    getTime()));
            statement.setDate(8, new Date(task.getUpdatedAt().
                    getTime()));
            statement.execute();
        } catch (Exception e) {
            throw new RuntimeException("Erro ao salvar a tarefa", e);
        } finally {
            ConnectionFactory.closeConnection(conn, statement);
        }
    }

    public void update(Task task) {
        String sql = "UPDATE tasks SET "
                + "id_project = ?,"
                + "name = ?,"
                + "description = ?,"
                + "completed = ?,"
                + "notes = ?,"
                + "deadline = ?,"
                + "createdAt = ?,"
                + "updatedAt = ? "
                + "where id = ?";
        Connection conn = null;
        PreparedStatement statement = null;
        try {
            conn = ConnectionFactory.getConnection();
            statement = conn.prepareStatement(sql);
            statement.setInt(1, task.getId_project());
            statement.setString(2, task.getName());
            statement.setString(3, task.getDescription());
            statement.setBoolean(4, task.getCompleted());
            statement.setString(5, task.getNotes());
            statement.setDate(6, new Date(task.getDeadline().
                    getTime()));
            statement.setDate(7, new Date(task.getCreatedAt().
                    getTime()));
            statement.setDate(8, new Date(task.getUpdatedAt().
                    getTime()));
            statement.setInt(9, task.getId());
            statement.execute();
        } catch (Exception e) {
            throw new RuntimeException("Erro ao atualizar tarefa", e);
        }
    }

    public void removeById(int taskId) throws SQLException {
        String sql = "DELETE FROM tasks WHERE id = ?";
        Connection conn = null;
        PreparedStatement statement = null;

        try {
            conn = ConnectionFactory.getConnection();
            statement = conn.prepareStatement(sql);
            statement.setInt(1, taskId);
            statement.execute();
        } catch (RuntimeException e) {
            throw new RuntimeException("Erro ao deletar tarefa.", e);
        } finally {
            ConnectionFactory.closeConnection(conn, statement);
        }
    }

    public List<Task> getAll(int id_project) {
        String sql = "SELECT * FROM tasks WHERE id_project = ?";
        Connection conn = null;
        PreparedStatement statement = null;
        ResultSet result = null;
        List<Task> tasks = new ArrayList<Task>();
        try {
            conn = ConnectionFactory.getConnection();
            statement = conn.prepareStatement(sql);
            statement.setInt(1, id_project);
            result = statement.executeQuery();

            while (result.next()) {
                Task task = new Task();
                task.setId(result.getInt("id"));
                task.setId_project(result.getInt(""
                        + "id_project"));
                task.setName(result.getString("name"));
                task.setDescription(result.getString(""
                        + "description"));
                task.setCompleted(result.getBoolean(""
                        + "completed"));
                task.setNotes(result.getString("notes"));
                task.setDeadline(result.getDate("deadline"));
                task.setCreatedAt(result.getDate("createdAt"));
                task.setUpdatedAt(result.getDate("updatedAt"));
                tasks.add(task);
            }
        } catch (Exception e) {
            throw new RuntimeException("Erro ao buscar tarefas.", e);
        } finally {
            ConnectionFactory.closeConnection(conn, statement, result);
        }
        return tasks;
    }
}
