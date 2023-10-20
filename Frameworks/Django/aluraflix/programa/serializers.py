from rest_framework import serializers
from programa.models import Programa


class ProgramaSerializer(serializers.ModelSerializer):
    class Meta:
        model = Programa
        fields = ['id', 'titulo', 'descricao', 'tipo', 'data_lancamento', 'likes']
