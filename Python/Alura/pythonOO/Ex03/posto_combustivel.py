class PostoCombustivel:
    def __init__(self, valor, quantidade):
        self._valor = valor
        self._quantidade = quantidade

    def abastecer_por_valor(self, valor_abastecimento):
        litros = valor_abastecimento / self._valor
        if self._quantidade < litros:
            print("Estoque insuficiente para o abastecimento.")
        else:
            self._quantidade -= litros
            print(f"Abasteceu {litros}l e pagou R$ {litros * self._valor}")

    def alterar_valor_combustivel(self, novo_valor: float):
        if novo_valor <= 0:
            print("Valor inválido, informe um valor maior que zero.")
        else:
            print(f"Valor alterado de R$ {self._valor} para R$ {novo_valor}")
            self._valor = novo_valor

    def alterar_quantidade_estoque(self, nova_quantidade):
        if nova_quantidade <= 0:
            print("Quantidade inválida, informe um valor maior que zero.")
        else:
            print(f"Quantidade alterada de {self._quantidade}l para {nova_quantidade}l")
            self._quantidade = nova_quantidade

    @property
    def valor(self):
        return self._valor

    @property
    def quantidade(self):
        return self._quantidade

    @quantidade.setter
    def quantidade(self, quantidade):
        self._quantidade = quantidade
