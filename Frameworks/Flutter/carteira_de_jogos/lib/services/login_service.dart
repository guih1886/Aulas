import 'dart:convert';

import 'package:http/http.dart' as http;

class LoginService {
  final String _url = "http://10.0.2.2:5000";

  Future<String?> login(String email, String password) async {
    var response = await http.post(Uri.parse("$_url/Login"),
        body: json.encode({'email': email, 'senha': password}),
        headers: {"Content-type": "application/json"});

    if (response.statusCode != 200) return null;

    return response.body;
  }
}
