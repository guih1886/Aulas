class conta_corrente:
    def __init__(self, conta, correntista):
        self._conta = conta
        self._correntista = correntista
        self.__saldo = 0

    def alterar_correntista(self, novo_correntista):
        if type(novo_correntista) == str:
            self._correntista = novo_correntista
        else:
            print("Nome do correntista inválido.")

    def sacar(self, valor):
        if valor >= self.__saldo:
            print("Saldo insuficiente.")
        else:
            self.__saldo -= valor
            print("Você sacou R${} com sucesso.".format(valor))

    def depositar(self, valor):
        if valor <= 0:
            print("Valor de depósito deve ser maior que zero.")
        else:
            self.__saldo += valor
            print("Você depositou R${} com sucesso.".format(valor))

    def __str__(self):
        return "Conta número {} de {} - Saldo Disponivel: R${}".format(self._conta, self._correntista, self.__saldo)
