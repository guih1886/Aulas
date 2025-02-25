import 'dart:convert';

import 'package:http/http.dart' as http;
import 'package:jwt_decoder/jwt_decoder.dart';
import 'package:shared_preferences/shared_preferences.dart';

class LoginService {
  final String _url = "http://10.0.2.2:5000";

  Future<String?> login(String? email, String? password) async {
      var response = await http.post(Uri.parse("$_url/Login"),
          body: json.encode({'email': email, 'senha': password}),
          headers: {"Content-type": "application/json"});

      if (response.statusCode != 200) return null;

      await saveUserInfo(response.body);

      return "Usuário logado com sucesso.";
  }

  saveUserInfo(String token) async {
      SharedPreferences prefs = await SharedPreferences.getInstance();
      prefs.setString("token", token);

      Map<String, dynamic> decodedToken = JwtDecoder.decode(token);

      prefs.setString("email", decodedToken["email"]);
      prefs.setInt("id", int.parse(decodedToken["id"]));
      prefs.setInt("dataExpiracao", decodedToken["exp"]);

  }

}
