import 'package:flutter_tarefas/components/task.dart';
import 'package:flutter_tarefas/data/database.dart';
import 'package:sqflite/sqflite.dart';

class TaskDAO {
  static const String tabela = "CREATE TABLE Tasks ("
      "id INTEGER PRIMARY KEY AUTOINCREMENT, "
      "nome TEXT, "
      "dificuldade INTEGER, "
      "imagem TEXT)";

  void salvar(Task tarefa) async {
    Database db = await getDatabase();
    db.insert("Tasks", toMap(tarefa));
  }

  Future<List<Task>> listarTodas() async {
    Database db = await getDatabase();
    List<Map<String, dynamic>> result = await db.query("Tasks");
    return toList(result);
  }

  Future<List<Task>> buscarPorNome(String nomeTarefa) async {
    Database db = await getDatabase();
    List<Map<String, Object?>> result =
        await db.query("Tasks", where: "nome = ?", whereArgs: [nomeTarefa]);
    return toList(result);
  }

  void deletar(String nome) async {
    Database db = await getDatabase();
    await db.delete("Tasks", where: "nome = ?", whereArgs: [nome]);
  }

  List<Task> toList(List<Map<String, dynamic>> lista) {
    final List<Task> tarefas = [];
    for (Map<String, dynamic> item in lista) {
      final Task tarefa = Task(
          name: item["nome"], difficult: item["dificuldade"], src: item["imagem"]);
      tarefas.add(tarefa);
    }
    return tarefas;
  }

  Map<String, dynamic> toMap(Task tarefa) {
    final Map<String, dynamic> mapaTarefas = {};
    mapaTarefas["nome"] = tarefa.name;
    mapaTarefas["dificuldade"] = tarefa.difficult;
    mapaTarefas["imagem"] = tarefa.src;
    return mapaTarefas;
  }
}
