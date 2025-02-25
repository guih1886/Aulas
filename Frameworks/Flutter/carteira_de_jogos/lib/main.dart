import 'package:carteira_de_jogos/screens/home_screen.dart';
import 'package:carteira_de_jogos/screens/login_screen.dart';
import 'package:carteira_de_jogos/screens/signup_screen.dart';
import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(seedColor: Colors.deepPurple),
        useMaterial3: true,
      ),
      initialRoute: "login",
      routes: {
        "login": (context) => const LoginScreen(),
        "signup": (context) => const SignupScreen(),
        "home": (context) => const HomeScreen(),
      },
    );
  }
}
