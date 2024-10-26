class Pessoa {
  int _id;
  String _nome;
  int _idade;
  bool _estaAutenticada;


  Pessoa(this._nome, this._idade, this._estaAutenticada);

  set nome(String value) {
    _nome = value;
  }

  set idade(int value) {
    _idade = value;
  }

  set estaAutenticada(bool value) {
    _estaAutenticada = value;
  }

  String get nome => _nome;

  int get idade => _idade;

  bool get estaAutenticada => _estaAutenticada;

  Map<String, dynamic> toMap() {
    Map<String, dynamic> resultado = {};

    resultado["nome"] = this._nome;
    resultado["idade"] = this._idade;
    resultado["estaAutenticada"] = this._estaAutenticada;

    return resultado;
  }
}
