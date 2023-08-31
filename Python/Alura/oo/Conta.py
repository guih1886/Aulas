class Conta:
    def __init__(self, numero, titular, saldo, limite):
        self.numero = numero
        self.titular = titular
        self.saldo = saldo
        self.limite = limite

    def extrato(self):
        print("Saldo {} do titular {}.".format(self.saldo, self.titular))

    def sacar(self, valor):
        if valor > self.saldo:
            print("Saldo insuficiente.")
        else:
            self.saldo -= valor

    def depositar(self, valor):
        if valor <= 0:
            print("Valor inválido, informe um depósito maior que zero.")
        else:
            self.saldo += valor
            print("Depositado o valor {} na conta número {} de {}".format(valor, self.numero, self.titular))
