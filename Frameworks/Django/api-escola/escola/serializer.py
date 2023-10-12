from escola.models import Aluno, Curso
from rest_framework import serializers


class AlunoSerializer(serializers.ModelSerializer):

    class Meta:
        model = Aluno
        fields = ['id', 'nome', 'rg', 'cpf', 'data_nascimento']


class CursoSerializer(serializers.ModelSerializer):

    class Meta:
        model = Curso
        fields = '__all__'
