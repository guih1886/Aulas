import 'package:flutter/material.dart';

Future<dynamic> showConfirmationDialog(BuildContext context,
    {String title = "Atenção!",
    String content = "Você realmente deseja executar essa operação?",
    String affimativeOption = "Confirmar",
    String negativeOption = "Cancelar"}) {
  return showDialog(
      context: context,
      builder: (context) {
        return AlertDialog(
          title: Text(title,
              style:
                  const TextStyle(fontSize: 18, fontWeight: FontWeight.bold)),
          content: Text(content),
          actions: [
            TextButton(
                onPressed: () => Navigator.pop(context, true),
                child: Text(
                  affimativeOption.toUpperCase(),
                  style: const TextStyle(
                      fontSize: 18,
                      fontWeight: FontWeight.bold,
                      color: Colors.blueAccent),
                )),
            TextButton(
                onPressed: () => Navigator.pop(context, false),
                child: Text(
                  negativeOption.toUpperCase(),
                  style: const TextStyle(
                      fontSize: 18,
                      fontWeight: FontWeight.bold,
                      color: Colors.red),
                ))
          ],
        );
      });
}
