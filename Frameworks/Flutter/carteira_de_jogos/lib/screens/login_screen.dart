import 'package:carteira_de_jogos/services/login_service.dart';
import 'package:flutter/material.dart';
import 'package:shared_preferences/shared_preferences.dart';

class LoginScreen extends StatefulWidget {
  const LoginScreen({super.key});

  @override
  State<LoginScreen> createState() => _LoginScreenState();
}

class _LoginScreenState extends State<LoginScreen> {
  LoginService loginService = LoginService();
  final TextEditingController _userController = TextEditingController();
  final TextEditingController _passwordController = TextEditingController();
  bool _isPasswordHidden = true;

  @override
  void initState() {
    super.initState();
    handleLoggedUser();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Padding(
          padding: const EdgeInsets.only(top: 150, left: 8, right: 8),
          child: SingleChildScrollView(
            child: Column(
              children: [
                SizedBox(
                    width: 300,
                    height: 300,
                    child: Image.asset("assets/images/jogos.jpg",
                        fit: BoxFit.fill)),
                Padding(
                  padding: const EdgeInsets.only(top: 25),
                  child: TextField(
                    keyboardType: TextInputType.emailAddress,
                    controller: _userController,
                    decoration: InputDecoration(
                        labelText: "E-mail",
                        border: const OutlineInputBorder(),
                        prefixIcon: const Icon(Icons.email_outlined),
                        suffixIcon: IconButton(
                            onPressed: () {
                              _userController.text = "";
                            },
                            icon: const Icon(Icons.clear))),
                  ),
                ),
                Padding(
                    padding: const EdgeInsets.only(top: 10),
                    child: TextField(
                      controller: _passwordController,
                      obscureText: _isPasswordHidden,
                      decoration: InputDecoration(
                        labelText: "Senha",
                        border: const OutlineInputBorder(),
                        prefixIcon: const Icon(Icons.password_outlined),
                        suffixIcon: IconButton(
                          onPressed: () {
                            setState(() {
                              _isPasswordHidden =
                                  !_isPasswordHidden; // Alterna a visibilidade
                            });
                          },
                          icon: Icon(
                            _isPasswordHidden
                                ? Icons.visibility
                                : Icons.visibility_off,
                          ),
                        ),
                      ),
                    )),
                Column(
                  children: [
                    Padding(
                      padding: const EdgeInsets.only(top: 10),
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                        crossAxisAlignment: CrossAxisAlignment.center,
                        children: [
                          FilledButton(
                            onPressed: () {
                              handleLogin();
                            },
                            child: const Text('Login'),
                          ),
                        ],
                      ),
                    ),
                    Padding(
                      padding: const EdgeInsets.only(top: 10),
                      child: TextButton(
                          onPressed: () {
                            Navigator.pushNamed(context, "signup");
                          },
                          child:
                              const Text("Novo? Clique aqui e cadastre-se!")),
                    )
                  ],
                )
              ],
            ),
          )),
    );
  }

  handleLogin() async {
    await loginService
        .login(_userController.text, _passwordController.text)
        .then((value) {
      if (value != null) {
        Navigator.pushReplacementNamed(context, "home");
      } else {
        ScaffoldMessenger.of(context).showSnackBar(const SnackBar(
            content: Text("Usuário ou senha inválido(s), tente novamente.")));
      }
    });
  }

  handleLoggedUser() async {
    SharedPreferences prefs = await SharedPreferences.getInstance();
    String? email = prefs.getString("email");
    DateTime dataExpiracaoToken;
    bool isValido;

    int? timestamp = prefs.getInt("dataExpiracao");

    if (timestamp != null) {
      dataExpiracaoToken =
          DateTime.fromMillisecondsSinceEpoch(timestamp * 1000);
      isValido = dataExpiracaoToken.isAfter(DateTime.now());

      if (email != null && email != "" && isValido) {
        Navigator.pushReplacementNamed(context, "home");
      } else {
        ScaffoldMessenger.of(context)
            .showSnackBar(const SnackBar(content: Text("Login expirado.")));
      }
    }
  }
}
