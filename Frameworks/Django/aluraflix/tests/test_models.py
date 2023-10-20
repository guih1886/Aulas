from django.test import TestCase
from programa.models import Programa


class ProgramaModelTestCase(TestCase):

    def setUp(self):
        self.programa = Programa(
            titulo='Procurando ninguem',
            data_lancamento='2003-07-04'
        )

    def test_verifica_atributos_do_programa(self):
        """Teste de verificação de atributos default"""
        self.assertEqual(self.programa.titulo, 'Procurando ninguem')
        self.assertEqual(self.programa.descricao, '')
        self.assertEqual(self.programa.tipo, 'F')
        self.assertEqual(self.programa.data_lancamento, '2003-07-04')
        self.assertEqual(self.programa.likes, 0)
        self.assertEqual(self.programa.dislikes, 0)