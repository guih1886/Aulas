import 'package:flutter/material.dart';
import 'package:flutter_tarefas/components/task.dart';

class TaskInherited extends InheritedWidget {
  TaskInherited({
    super.key,
    required super.child,
  });

  final List<Task> taskList = [
    const Task(
      name: 'Estudar Flutter',
      difficult: 1,
      src: "assets/images/dash.png",
    ),
    const Task(
      name: 'Andar de Bike',
      difficult: 0,
      src: 'assets/images/bike.webp',
    ),
    const Task(
      name: 'Ler',
      difficult: 2,
      src: "assets/images/book.jpg",
    ),
    const Task(
      name: 'Meditar',
      difficult: 5,
      src: "assets/images/meditate.jpeg",
    ),
    const Task(
      name: 'Jogar',
      difficult: 1,
      src: "assets/images/play.jpg",
    ),
  ];

  static TaskInherited of(BuildContext context) {
    final TaskInherited? result =
        context.dependOnInheritedWidgetOfExactType<TaskInherited>();
    assert(result != null, 'No TaskInherited found in context');
    return result!;
  }

  @override
  bool updateShouldNotify(TaskInherited oldWidget) {
    return oldWidget.taskList.length != taskList.length;
  }

  void newTask(String name, int difficult, String image) {
    taskList.add(Task(name: name, difficult: difficult, src: image));
  }
}
