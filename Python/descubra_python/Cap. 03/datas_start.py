#
# Arquivo com exemplos de manipulação de  datas
#

from datetime import date
from datetime import time
from datetime import datetime


def manipulaDataHora():
    hoje = date.today()
    print("Hoje: ", hoje)
    print("Partes da data: ", hoje.day, hoje.month, hoje.year)
    print("Numero do dia da semana: ", hoje.weekday())
    dias = ['seg', 'ter', 'qua', 'qui', 'sex', 'sab', 'dom']
    print("Hoje: ", dias[hoje.weekday()])

    data = datetime.now()
    print("Data e Hora: ", data)

    tempo = datetime.time(data)
    print("Hora atual: ", tempo)


manipulaDataHora()
