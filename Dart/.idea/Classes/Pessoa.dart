class Pessoa {
  String nome;
  int idade;
  bool estaAutenticada;

  Pessoa(this.nome, this.idade, this.estaAutenticada);

  /* teste */
  Map<String, dynamic> toMap() {
    Map<String, dynamic> resultado = {};

    resultado["nome"] = this.nome;
    resultado["idade"] = this.idade;
    resultado["estaAutenticada"] = this.estaAutenticada;

    return resultado;
  }
}
