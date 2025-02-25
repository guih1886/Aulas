import 'dart:convert';

import 'package:flutter/services.dart';

import '../models/oferta_model.dart';

class OfertaService {
  Future<List<OfertaModel>?> carregarOfertas() async {
    try {
      String jsonString = await rootBundle.loadString('assets/db/db.json');

      final Map<String, dynamic> jsonData = json.decode(jsonString);

      List<OfertaModel> listaOfertas = (jsonData['ofertas'] as List)
          .map((json) => OfertaModel.fromJson(json))
          .toList();

      return listaOfertas;
    } catch (e) {
      return null;
    }
  }
}
