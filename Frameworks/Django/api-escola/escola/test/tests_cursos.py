from rest_framework.test import APITestCase
from escola.models import Curso
from django.urls import reverse
from rest_framework import status


class CursosTestCase(APITestCase):

    def setUp(self) -> None:
        self.list_url = reverse('Cursos-list')
        self.curso_1 = Curso.objects.create(
            codigo_curso="CTT1", descricao="Curso Teste 1", nivel="B"
        )
        self.curso_2 = Curso.objects.create(
            codigo_curso="CTT2", descricao="Curso Teste 2", nivel="A"
        )

    def test_requisicao_get_para_listar_cursos(self):
        """ Teste de verificação de requisição GET """
        response = self.client.get(self.list_url)
        self.assertEquals(response.status_code, status.HTTP_200_OK)

    def test_requisicao_post_para_criar_curso(self):
        """ Teste de verificação de requisição POST """
        data = {
            'codigo_curso': 'CTT3',
            'descricao': 'Curso Teste 3',
            'nivel': 'I'
        }
        response = self.client.post(self.list_url, data)
        self.assertEquals(response.status_code, status.HTTP_201_CREATED)

    def test_requisicao_delete_para_deletar_curso(self):
        """ Teste para verificar a requisição delete não permitida """
        response = self.client.delete('/cursos/1/')
        self.assertEquals(response.status_code,
                          status.HTTP_405_METHOD_NOT_ALLOWED)

    def test_requisicao_put_para_atualizar_curso(self):
        """ Teste para verificar a requisição put para atualizar o curso """
        data = {
            'codigo_curso': 'CTT1',
            'descricao': 'Curso de Teste 1 atualizado',
            'nivel': 'I'
        }
        response = self.client.put('/cursos/1/', data)
        self.assertEquals(response.status_code, status.HTTP_200_OK)
        self.assertEquals(
            response.data['descricao'], 'Curso de Teste 1 atualizado')


"""     def test_falhador(self):
        self.fail("Teste de falha.") """
