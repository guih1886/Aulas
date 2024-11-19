import 'package:flutter/material.dart';

class SectionButton extends StatefulWidget {
  final String icone;
  final String titulo;
  final String href;

  const SectionButton(
      {super.key,
      required this.titulo,
      required this.icone,
      required this.href});

  @override
  State<SectionButton> createState() => _SectionButtonState();
}

class _SectionButtonState extends State<SectionButton> {
  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      onTap: () => Navigator.pushNamed(context, widget.href),
      child: Padding(
        padding: const EdgeInsets.only(left: 30, bottom: 20),
        child: Container(
          decoration: BoxDecoration(
            color: const Color.fromRGBO(11, 59, 96, 2),
            borderRadius: BorderRadius.circular(15),
          ),
          width: 350,
          height: 150,
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            crossAxisAlignment: CrossAxisAlignment.center,
            children: [
              Container(
                padding: const EdgeInsets.only(bottom: 10),
                width: 100,
                height: 90,
                child: Image.network(widget.icone, fit: BoxFit.fill),
              ),
              Text(
                widget.titulo,
                style: const TextStyle(
                    color: Colors.white,
                    decoration: TextDecoration.none,
                    fontSize: 18),
              )
            ],
          ),
        ),
      ),
    );
  }
}
