from django.test import TestCase
from programa.models import Programa
from programa.serializers import ProgramaSerializer


class ProgramaSerializerTestCase(TestCase):

    def setUp(self) -> None:
        # Cria o teste de unidade apartir de programa, e não de integração usando .objects.all
        self.programa = Programa(
            titulo='Procurando ninguem',
            data_lancamento='2003-07-04',
            tipo='F',
            likes=531,
            dislikes=28
        )
        self.serializer = ProgramaSerializer(instance=self.programa)

    def test_verifica_campos_serializados(self):
        """Verifica os campos sendo serializados"""
        data = self.serializer.data
        self.assertEqual(set(data.keys()), set(
            ['id', 'titulo', 'descricao', 'tipo', 'data_lancamento', 'likes']))

    def test_verifica_conteudo_dos_campos_serializados(self):
        """Verificação dos conteúdos serializados"""
        data = self.serializer.data
        self.assertEqual(data['titulo'], self.programa.titulo)
        self.assertEqual(data['data_lancamento'],
                         self.programa.data_lancamento)
        self.assertEqual(data['tipo'], self.programa.tipo)
        self.assertEqual(data['likes'], self.programa.likes)
