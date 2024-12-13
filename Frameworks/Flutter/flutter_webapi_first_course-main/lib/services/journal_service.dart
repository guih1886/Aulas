import 'dart:convert';

import 'package:flutter_webapi_first_course/models/journal.dart';
import 'package:http/http.dart' as http;

class JournalService {
  final String url = "http://192.168.15.2:3000/journals";

  Future<bool> register(Journal journal) async {
    String journalJson = json.encode(journal.toMap());
    http.Response response = await http.post(Uri.parse(url),
        body: journalJson, headers: {"Content-type": "application/json"});
    return response.statusCode == 201 ? true : false;
  }

  Future<bool> edit(String id, Journal journal) async {
    String journalJson = json.encode(journal.toMap());

    http.Response response = await http.put(Uri.parse("$url/$id"),
        body: journalJson, headers: {"Content-type": "application/json"});

    if (response.statusCode == 200) return true;
    return false;
  }

  Future<bool> delete(String id) async {
    http.Response response = await http.delete(Uri.parse("$url/$id"));

    if (response.statusCode == 200) return true;
    return false;
  }

  Future<List<Journal>> getAll() async {
    http.Response response = await http.get((Uri.parse(url)));

    if (response.statusCode != 200) {
      throw Exception("Erro ao buscar os dados.");
    }

    List<Journal> list = [];

    List<dynamic> listagem = json.decode(response.body);

    for (var item in listagem) {
      list.add(Journal.fromMap(item));
    }

    return list;
  }
}
