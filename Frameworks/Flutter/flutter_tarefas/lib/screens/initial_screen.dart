import 'package:flutter/material.dart';
import 'package:flutter_tarefas/data/task_inherited.dart';
import 'package:flutter_tarefas/screens/form_screen.dart';

class InitialScreen extends StatefulWidget {
  const InitialScreen({super.key});

  @override
  State<InitialScreen> createState() => _InitialScreenState();
}

class _InitialScreenState extends State<InitialScreen> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Colors.blue,
        title: const Text('Tarefas', style: TextStyle(color: Colors.white)),
      ),
      body: Column(
        children: [
          SizedBox(
            width: 412,
            height: 735,
            child: ListView(
              children: TaskInherited.of(context).taskList,
            ),
          ),
        ],
      ),
      floatingActionButton: FloatingActionButton(
        onPressed: () {
          Navigator.push(
              context,
              MaterialPageRoute(
                  builder: (contextNew) => FormScreen(taskContext: context)));
        },
        child: const Icon(Icons.add),
      ),
    );
  }
}
