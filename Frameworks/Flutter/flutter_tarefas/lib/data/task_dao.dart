import 'package:flutter_tarefas/components/task.dart';
import 'package:flutter_tarefas/data/database.dart';
import 'package:sqflite/sqflite.dart';

class TaskDAO {
  static const String tabela = "CREATE TABLE Tasks ("
      "id INTEGER PRIMARY KEY AUTOINCREMENT, "
      "$_nome TEXT, "
      "$_dificuldade INTEGER, "
      "$_imagem TEXT)";

  static const String _nome = "";
  static const int _dificuldade = 0;
  static const String _imagem = "";

  void salvar(Task terafa) async {
    Database db = await getDatabase();
    db.insert("Tasks", value)
  }

  Future<List<Task>> listarTodas() async {
    Database db = await getDatabase();
    List<Map<String, dynamic>> result = await db.query("Tasks");
    return toList(result);
  }

  Future<List<Task>> buscarPorNome(String nomeTarefa) async {
    Database db = await getDatabase();
    List<Map<String, Object?>> result =
        await db.query("Tasks", where: "$_nome = ?", whereArgs: [nomeTarefa]);
    return toList(result);
  }

  void deletar(int id) async {
    Database db = await getDatabase();
    await db.delete("Tasks", where: "id = ?", whereArgs: [id]);
  }

  List<Task> toList(List<Map<String, dynamic>> lista) {
    final List<Task> tarefas = [];
    for (Map<String, dynamic> item in lista) {
      final Task tarefa = Task(
          name: item[_nome], difficult: item[_dificuldade], src: item[_imagem]);
      tarefas.add(tarefa);
    }
    return tarefas;
  }

  Map<String, dynamic> toMap(Task tarefa){
      
  }
}
