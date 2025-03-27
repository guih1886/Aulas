import 'package:flutter_test/flutter_test.dart';
import 'package:pi_desenv_mobile/models/oferta_model.dart';
import 'package:pi_desenv_mobile/models/produto_model.dart';
import 'package:pi_desenv_mobile/services/oferta_service.dart';

void main() async {
  TestWidgetsFlutterBinding.ensureInitialized();

  group("Verificação dos dados:", () {
    test("Todos os itens da lista deve conter id e titulo", () async {
      List<OfertaModel>? listaDeOfertas =
          await OfertaService().carregarOfertas();
      expect(listaDeOfertas, isNotEmpty);

      for (OfertaModel item in listaDeOfertas!) {
        expect(item.id, allOf(isNotNull, isA<int>(), isNonNegative),
            reason: "O ID não pode ser nulo ou negativo e deve ser um inteiro");
        expect(item.titulo, allOf(isNotEmpty, isNotNull));
      }
    });

    test("Todos os itens da lista deve conter um link do folheto", () async {
      List<OfertaModel>? listaDeOfertas =
          await OfertaService().carregarOfertas();

      for (OfertaModel item in listaDeOfertas!) {
        expect(item.folheto, allOf(isA<String>(), isNotEmpty, isNotNull));
      }
    });

    test("Todos os itens da lista deve conter data de inicio e data de fim",
        () async {
      List<OfertaModel>? listaDeOfertas =
          await OfertaService().carregarOfertas();

      for (var oferta in listaDeOfertas!) {
        expect(oferta.dataInicio, isNotNull);
        expect(oferta.dataFim, isNotNull);
      }
    });

    test("Todos os itens da lista deve conter uma lista de produtos", () async {
      List<OfertaModel>? listaDeOfertas =
          await OfertaService().carregarOfertas();

      for (var oferta in listaDeOfertas!) {
        expect(oferta.produtos, isA<List<ProdutoModel>>());
      }
    });
  });

  group("Casos excepcionais:", () {
    test("Lista de ofertas deve ser uma lista", () async {
      List<OfertaModel>? listaDeOfertas =
          await OfertaService().carregarOfertas();

      expect(listaDeOfertas, isA<List<OfertaModel>>());
    });

    test("Lista de ofertas precisa ter pelo menos uma oferta", () async {
      List<OfertaModel>? listaDeOfertas =
          await OfertaService().carregarOfertas();

      expect(listaDeOfertas, hasLength(greaterThanOrEqualTo(1)));
    });

    test("Verifica se as datas de inicio e fim são datetimes válidos",
        () async {
      List<OfertaModel>? listaDeOfertas =
          await OfertaService().carregarOfertas();

      for (var oferta in listaDeOfertas!) {
        expect(oferta.dataInicio, isA<DateTime>());
        expect(oferta.dataFim, isA<DateTime>());

        expect(oferta.dataFim.isAfter(oferta.dataInicio), isTrue,
            reason: "dataFim deve ser posterior a dataInicio");
      }
    });

    test("A lista de produtos da oferta não pode ser vazia ou nula", () async {
      List<OfertaModel>? listaDeOfertas =
          await OfertaService().carregarOfertas();

      for (var oferta in listaDeOfertas!) {
        expect(oferta.produtos, allOf(isNotEmpty, isNotNull));
      }
    });
  });
}
