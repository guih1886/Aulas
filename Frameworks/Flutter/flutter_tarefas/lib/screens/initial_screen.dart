import 'package:flutter/material.dart';

import '../components/task.dart';

class InitialScreen extends StatefulWidget {
  const InitialScreen({super.key});

  @override
  State<InitialScreen> createState() => _InitialScreenState();
}

class _InitialScreenState extends State<InitialScreen> {
  bool opacity = true;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Colors.blue,
        title: const Text('Tarefas', style: TextStyle(color: Colors.white)),
        leading: Container(),
      ),
      body: AnimatedOpacity(
        duration: const Duration(milliseconds: 250),
        opacity: opacity ? 1 : 0,
        child: ListView(
          children: const [
            Padding(
              padding: EdgeInsets.only(top: 8),
              child: Tasks(
                name: 'Estudar Flutter',
                difficult: 1,
                src: "assets/images/dash.png",
              ),
            ),
            Tasks(
              name: 'Andar de Bike',
              difficult: 0,
              src: 'assets/images/bike.webp',
            ),
            Tasks(
              name: 'Ler',
              difficult: 2,
              src: "assets/images/book.jpg",
            ),
            Tasks(
              name: 'Meditar',
              difficult: 5,
              src: "assets/images/meditate.jpeg",
            ),
            Tasks(
              name: 'Jogar',
              difficult: 1,
              src: "assets/images/play.jpg",
            ),
            SizedBox(height: 60)
          ],
        ),
      ),
      floatingActionButton: FloatingActionButton(
        onPressed: () {
          setState(() {
            opacity = !opacity;
          });
        },
        child: const Icon(Icons.remove_red_eye),
      ),
    );
  }
}
