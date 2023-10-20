from rest_framework.test import APITestCase
from rest_framework import status
from django.contrib.auth.models import User
from django.contrib.auth import authenticate
from django.urls import reverse


class AuthenticationUserTestCase(APITestCase):

    def setUp(self) -> None:
        self.list_urls = reverse('programas-list')
        self.user = User.objects.create_user(
            username='c3po', password='123456')

    def test_autenticacao_user_com_credenciais_corretas(self):
        """Tesde de autenticação com credenciais corretas"""
        user = authenticate(username='c3po', password='123456')
        self.assertTrue((user is not None) and user.is_authenticated)

    def test_autenticacao_user_com_credenciais_incorretas(self):
        """Tesde de autenticação com credenciais incorretas"""
        user = authenticate(username='c3po', password='123')
        self.assertTrue((user is None) or not user.is_authenticated)

    def test_requisicao_get_sem_autenticacao(self):
        """Teste de tentativa de requisição get não autorizada"""
        response = self.client.get(self.list_urls)
        self.assertEqual(response.status_code, status.HTTP_401_UNAUTHORIZED)
        
    def test_requisicao_get_com_autenticacao(self):
        """Teste de tentativa de requisição get autorizada"""
        self.client.force_authenticate(self.user)
        response = self.client.get(self.list_urls)
        self.assertEqual(response.status_code, status.HTTP_200_OK)
