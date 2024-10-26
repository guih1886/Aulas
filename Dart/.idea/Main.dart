import 'Classes/Pessoa.dart';

void main() {
  Pessoa pessoa = new Pessoa("teste", 30, true);
  pessoa.idade = 10;

  print("${pessoa.idade}");

  Iterable<Pessoa> pessoas = [];

  print(pessoas);
}
