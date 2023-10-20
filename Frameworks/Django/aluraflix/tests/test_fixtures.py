from django.test import TestCase
from programa.models import Programa


class FixtureDataTestCase(TestCase):
    """Carregando as fixtures no banco de dados de teste"""
    fixtures = ['programas_iniciais']

    def test_verifica_carregamento_da_fixture(self):
        """Verificando os dados da fixture"""
        programa_bizarro = Programa.objects.get(pk=1)
        programas = Programa.objects.all()

        self.assertEqual(programa_bizarro.titulo, 'Coisas bizarras')
        self.assertEqual(len(programas), 9)
