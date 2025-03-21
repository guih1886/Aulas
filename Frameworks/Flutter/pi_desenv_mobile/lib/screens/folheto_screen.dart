import 'package:flutter/material.dart';
import 'package:dio/dio.dart';
import 'package:path_provider/path_provider.dart';
import 'package:open_file/open_file.dart';
import 'dart:io';

import '../models/oferta_model.dart';
import '../services/oferta_service.dart';

class FolhetoScreen extends StatefulWidget {
  const FolhetoScreen({super.key});

  @override
  State<FolhetoScreen> createState() => _FolhetoScreenState();
}

class _FolhetoScreenState extends State<FolhetoScreen> {
  Dio dio = Dio();
  final OfertaService ofertaService = OfertaService();
  List<OfertaModel> ofertas = [];

  @override
  void initState() {
    super.initState();
    carregarDados();
  }

  Future<void> carregarDados() async {
    List<OfertaModel>? lista = await ofertaService.carregarOfertas();
    setState(() {
      if (lista != null) {
        ofertas = lista;
      }
    });
  }

  Future<void> downloadAndSaveImage(String url) async {
    try {
      final directory = await getApplicationDocumentsDirectory();
      var fileName = DateTime.now().microsecondsSinceEpoch;
      final filePath = '${directory.path}/$fileName';

      Response response = await Dio().get(
        url,
        options: Options(responseType: ResponseType.bytes),
      );

      File file = File(filePath);
      await file.writeAsBytes(response.data);

      OpenFile.open(filePath);
    } catch (e) {
      print('Erro ao baixar e salvar imagem: $e');
    }
  }

  @override
  Widget build(BuildContext context) {
    var fontSize = MediaQuery.of(context).textScaler.scale(16);

    return SafeArea(
      child: Scaffold(
        appBar: AppBar(
            title: const Text("Folhetos"),
            backgroundColor: const Color.fromRGBO(255, 200, 255, 0.5)),
        body: ofertas.isEmpty
            ? const Center(child: CircularProgressIndicator())
            : ListView.builder(
                itemCount: ofertas.length,
                itemBuilder: (context, index) {
                  OfertaModel oferta = ofertas[index];
                  return Padding(
                    padding: const EdgeInsets.all(10),
                    child: Card(
                      color: Colors.white70,
                      child: Column(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: <Widget>[
                          Image.network(oferta.folheto, fit: BoxFit.fill),
                          Padding(
                            padding: const EdgeInsets.all(10),
                            child: Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Text(oferta.titulo,
                                    style: TextStyle(
                                        fontSize: fontSize,
                                        fontWeight: FontWeight.bold)),
                                ElevatedButton(
                                  onPressed: () {
                                    downloadAndSaveImage(oferta.folheto);
                                  },
                                  child: const Text('Baixar Folheto'),
                                ),
                              ],
                            ),
                          ),
                        ],
                      ),
                    ),
                  );
                },
              ),
      ),
    );
  }
}
