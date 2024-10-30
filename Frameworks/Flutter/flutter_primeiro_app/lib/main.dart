import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        title: 'Flutter',
        theme: ThemeData(
          colorScheme: ColorScheme.fromSeed(seedColor: Colors.deepPurple),
          useMaterial3: true,
        ),
        home: Container(
            alignment: AlignmentDirectional.center,
            color: Colors.black,
            child: Column(
              mainAxisAlignment: MainAxisAlignment.spaceAround,
              crossAxisAlignment: CrossAxisAlignment.center,
              children: [
                Row(
                  mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                  children: [
                    Container(color: Colors.red, width: 100, height: 100),
                    Container(color: Colors.orange, width: 100, height: 100),
                    Container(color: Colors.yellow, width: 100, height: 100),
                  ],
                ),
                Row(
                  mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                  children: [
                    Container(color: Colors.red, width: 100, height: 100),
                    Container(color: Colors.orange, width: 100, height: 100),
                    Container(color: Colors.yellow, width: 100, height: 100),
                  ],
                ),
                Row(
                  mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                  children: [
                    Container(color: Colors.red, width: 100, height: 100),
                    Container(color: Colors.orange, width: 100, height: 100),
                    Container(color: Colors.yellow, width: 100, height: 100),
                  ],
                ),
                Row(
                  mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                  children: [
                    ElevatedButton(
                        onPressed: () => print("Cadastrando."),
                        iconAlignment: IconAlignment.end,
                        style: const ButtonStyle(
                            alignment: AlignmentDirectional.center),
                        child: const Text(
                          "Cadastrar",
                          style: TextStyle(fontSize: 25),
                        )),
                    ElevatedButton(
                        onPressed: () => print("Cancelando."),
                        iconAlignment: IconAlignment.end,
                        style: const ButtonStyle(
                            alignment: AlignmentDirectional.center),
                        child: const Text(
                          "Cancelar",
                          style: TextStyle(fontSize: 25),
                        )),
                  ],
                )
              ],
            )));
  }
}
