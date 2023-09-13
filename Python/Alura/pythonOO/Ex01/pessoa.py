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
        hoje = datetime.date.today().strftime("%d/%m/%Y")
        mes_atual = hoje[3:5]
        ano_atual = hoje[6:]
        mes_nascimento = self.__data_nascimento[3:5]
        ano_nascimento = self.__data_nascimento[6:]

        if mes_atual > mes_nascimento:
            idade = int(ano_atual) - int(ano_nascimento)
            print("{} tem {} anos.".format(self.__nome, idade))
        else:
            idade = int(ano_atual) - int(ano_nascimento) - 1
            print("{} tem {} anos.".format(self.__nome, idade))
