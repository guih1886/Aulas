import 'package:flutter/material.dart';
import 'package:vollmed/screens/home.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(seedColor: Colors.deepPurple),
        useMaterial3: true,
      ),
      initialRoute: "/home",
      routes: {
        "/home": (context) => const HomeScreen(),
        "/medicos/listagem": (context) => const HomeScreen(), //TODO alterar rota
        "/pacientes/listagem": (context) => const HomeScreen(), //TODO alterar rota
        "/consultas/listagem": (context) => const HomeScreen() //TODO alterar rota
      },
    );
  }
}
