from django.db import models


class Categoria(models.Model):
    nome = models.CharField(max_length=100, null=False, blank=False)
    ativo = models.BooleanField(default=True)

    def __str__(self):
        return self.nome


class Pesquisas(models.Model):
    categoria = models.ForeignKey(Categoria, on_delete=models.CASCADE)
    pergunta = models.CharField(max_length=256, null=False, blank=False)
    resposta = models.CharField(max_length=256, null=False, blank=False)

    def __str__(self):
        return self.pergunta