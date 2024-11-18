import 'package:flutter/material.dart';
import 'package:flutter_tarefas/data/task_inherited.dart';
import 'package:flutter_tarefas/screens/form_screen.dart';

import 'screens/initial_screen.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      initialRoute: "/",
      routes: {
        "/": (context) => TaskInherited(child: const InitialScreen()),
        "/FormScreen": (context) => const FormScreen()
      },
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
    );
  }
}
