from django.db import models
from django.utils.timezone import datetime


class Programa(models.Model):
    TIPO = (('F', 'Filme'), ('S', 'Série'))

    titulo = models.CharField(max_length=30)
    descricao = models.CharField(max_length=120, blank=True)
    tipo = models.CharField(max_length=1, choices=TIPO,
                            default='F', null=False, blank=False)
    data_lancamento = models.DateField(default=datetime.today)
    likes = models.PositiveIntegerField(default=0)
    dislikes = models.PositiveIntegerField(default=0)

    def __str__(self) -> str:
        return self.titulo
