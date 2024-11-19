import 'package:flutter/material.dart';
import 'package:vollmed/components/home/botao_secao.dart';

class HomeScreen extends StatefulWidget {
  const HomeScreen({super.key});

  @override
  State<HomeScreen> createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreen> {
  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        //Descrição
        Container(
          width: 450,
          height: 200,
          color: Colors.white,
          child: Padding(
            padding: const EdgeInsets.only(left: 28, top: 30),
            child: Column(
              mainAxisAlignment: MainAxisAlignment.center,
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Padding(
                  padding: const EdgeInsets.only(bottom: 8),
                  child: SizedBox(
                    width: 200,
                    height: 40,
                    child: Image.asset(
                      "assets/images/logo.png",
                      fit: BoxFit.fill,
                    ),
                  ),
                ),
                const Text(
                  "Gerenciando sua clínica",
                  style: TextStyle(
                      color: Color.fromRGBO(11, 59, 96, 2),
                      fontSize: 22,
                      fontFamily: "Cambria",
                      decoration: TextDecoration.none),
                )
              ],
            ),
          ),
        ),
        //Container para os botões de seção
        Container(
          color: Colors.white,
          width: 450,
          height: 690,
          child: const Column(
            mainAxisAlignment: MainAxisAlignment.start,
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Padding(
                padding: EdgeInsets.only(left: 35, bottom: 10, top: 25),
                child: Text(
                  "Escolha qual seção deseja iniciar:",
                  style: TextStyle(
                    fontSize: 14,
                    decoration: TextDecoration.none,
                    color: Colors.black,
                  ),
                ),
              ),
              SectionButton(
                titulo: "Médicos(as)",
                icone:
                    "https://cdn-icons-png.flaticon.com/512/1021/1021566.png",
                href: "/medicos/listagem",
              ),
              SectionButton(
                titulo: "Pacientes",
                icone:
                    "https://cdn-icons-png.flaticon.com/512/1430/1430453.png",
                href: "/pacientes/listagem",
              ),
              SectionButton(
                titulo: "Consultas",
                icone:
                    "https://cdn-icons-png.flaticon.com/512/1469/1469975.png",
                href: "/consultas/listagem",
              ),
            ],
          ),
        )
      ],
    );
  }
}
