class posto_combustivel:
    def __init__(self, valor, quantidade):
        self._valor = valor
        self._quantidade = quantidade

    def abastecer_por_litro(self):
        pass

    def abastecer_por_valor(self):
        pass

    def alterar_valor_combustivel(self):
        pass

    def alterar_quantidade_estoque(self):
        pass

    @property
    def valor(self):
        return self._valor

    @property
    def quantidade(self):
        return self._quantidade

    def __str__(self):
        pass
