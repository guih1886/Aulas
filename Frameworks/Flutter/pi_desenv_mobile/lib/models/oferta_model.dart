class OfertaModel {
  final int id;
  final String titulo;
  final DateTime dataInicio;
  final DateTime dataFim;
  final List<dynamic> produtos;

  OfertaModel({
    required this.id,
    required this.titulo,
    required this.dataInicio,
    required this.dataFim,
    required this.produtos,
  });

  factory OfertaModel.fromJson(Map<String, dynamic> json) {
    return OfertaModel(
      id: json['id'],
      titulo: json['titulo'],
      dataInicio: DateTime.parse(json['data_inicio']),
      dataFim: DateTime.parse(json['data_fim']),
      produtos: json['produtos'],
    );
  }
}
