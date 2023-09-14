class Elevador:
    def __init__(self, total_andares, lotacao):
        self.__andar_atual = 0
        self.__lotacao_atual = 0
        self.__total_andares = total_andares
        self.__lotacao = lotacao

    def entrar(self, pessoas):
        if (self.__lotacao_atual + pessoas) > self.__lotacao:
            print("Quantidade de pessoas excede a lotação máxima do elevador.")
        elif (self.__lotacao_atual + pessoas) == self.__lotacao:
            self.__lotacao_atual += pessoas
            print(f"Entrou {pessoas} no elevador, o elevador está cheio.")
        else:
            self.__lotacao_atual += pessoas
            print(f"Entrou {pessoas} no elevador, o elevador está com {self.__lotacao_atual} pessoas.")

    def sair(self, pessoas):
        if (self.__lotacao_atual - pessoas) > 0:
            self.__lotacao_atual -= pessoas
            print(f"Saiu {pessoas} pessoas do elevador, o elevador está com {self.__lotacao_atual} pessoas.")
        elif (self.__lotacao_atual - pessoas) == 0:
            self.__lotacao_atual -= pessoas
            print(f"Saiu {pessoas} pessoas do elevador, o elevador está vazio.")
        else:
            print(f"Não há {pessoas} pessoas no elevador, há {self.__lotacao_atual}.")

    def subir(self, andares):
        if (andares + self.__andar_atual) > self.__total_andares:
            print(f"Elevador não pode subir {andares} andares.")
        elif (andares + self.__andar_atual) <= self.__total_andares:
            self.__andar_atual += andares
            print(f"O elevador subiu para o {self.__andar_atual}° andar.")

    def descer(self, andares):
        if self.__andar_atual - andares < 0:
            print(f"O elevador não pode descer {andares} andares.")
        elif self.__andar_atual - andares > 0:
            self.__andar_atual -= andares
            print(f"O elevador desdeu {andares} andares, e está no {self.__andar_atual}° andar.")
        elif self.__andar_atual - andares == 0:
            self.__andar_atual -= andares
            print(f"O elevador desdeu {andares} andares, e está no térreo.")
