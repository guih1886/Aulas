import 'package:pi_desenv_mobile/models/produto_model.dart';

class OfertaModel {
  final int id;
  final String titulo;
  final String folheto;
  final DateTime dataInicio;
  final DateTime dataFim;
  final List<ProdutoModel> produtos;

  OfertaModel({
    required this.id,
    required this.titulo,
    required this.folheto,
    required this.dataInicio,
    required this.dataFim,
    required this.produtos,
  });

  factory OfertaModel.fromJson(Map<String, dynamic> json) {
    return OfertaModel(
      id: json['id'],
      titulo: json['titulo'],
      folheto: json['folheto'],
      dataInicio: DateTime.parse(json['data_inicio']),
      dataFim: DateTime.parse(json['data_fim']),
      produtos: (json['produtos'] as List)
          .map((produto) => ProdutoModel.fromJson(produto))
          .toList(),
    );
  }
}
