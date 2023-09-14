import datetime


class Pessoa:
    def __init__(self, nome, data_nascimento, altura):
        self.__nome = nome
        self.__data_nascimento = data_nascimento
        self.__altura = altura

    def imprimie_dados(self):
        print(
            "Nome: {} - Data de Nascimento: {} - Altura: {}".format(self.__nome, self.__data_nascimento, self.__altura))

    def calcula_idade(self):
        hoje = datetime.date.today()
        data_nascimento = datetime.datetime.strptime(self.__data_nascimento, "%d/%m/%Y")
        mes_atual = hoje.month
        ano_atual = hoje.year
        mes_nascimento = data_nascimento.month
        ano_nascimento = data_nascimento.year

        if mes_atual > mes_nascimento:
            idade = ano_atual - ano_nascimento
            print(f"{self.__nome} tem {idade} anos.")
        else:
            idade = int(ano_atual) - int(ano_nascimento) - 1
            print(f"{self.__nome} tem {idade} anos.")
