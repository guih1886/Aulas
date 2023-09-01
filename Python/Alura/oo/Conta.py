class Conta:
    def __init__(self, numero, titular, saldo, limite):
        self.__numero = numero  # encapsulamento é feito com __ (private)
        self.__titular = titular
        self.__saldo = saldo
        self.__limite = limite
        self.__codigo_banco = "001"

    def extrato(self):
        print("Saldo {} do titular {}.".format(self.__saldo, self.__titular))

    def __pode_sacar(self, valor):
        return valor > self.__saldo + self.__limite

    def sacar(self, valor):
        if self.__pode_sacar(valor):
            print("Saldo insuficiente.")
        else:
            self.__saldo -= valor
            print("Saque de {} do titular {} efetuado com sucesso.".format(valor, self.__titular))

    def depositar(self, valor):
        if valor <= 0:
            print("Valor inválido, informe um depósito maior que zero.")
        else:
            self.__saldo += valor
            print("Depositado o valor {} na conta número {} de {}".format(valor, self.__numero, self.__titular))

    def transferir(self, valor, destino):
        if valor <= self.__saldo:
            self.sacar(valor)
            destino.depositar(valor)
            print("Transferência efetuada com sucesso.")
        else:
            print("Saldo insuficiente.")

    @property  # define uma propriedade, age como um getter
    def saldo(self):
        return self.__saldo

    @property
    def titular(self):
        return self.__titular

    @property
    def limite(self):
        return self.__limite

    @limite.setter  # age como se fosse um setter, mas o property correspondente tem que estar setado
    def limite(self, novo_limite):
        self.__limite = novo_limite

    @staticmethod  # notação para tornar um método estático (static)
    def codigo_banco():
        return "001"
