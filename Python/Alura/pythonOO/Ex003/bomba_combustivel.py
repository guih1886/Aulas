from enum import Enum
from posto_combustivel import posto_combustivel


class tipo_combustivel(Enum):
    GASOLINA = 1
    ETANOL = 2
    DIESEL = 3


class bomba_combustivel(posto_combustivel):
    def __init__(self, combustivel: tipo_combustivel, valor_litro, quantidade_estoque):
        self._combustivel = combustivel
        super().__init__(valor_litro, quantidade_estoque)

    def alterar_tipo_combustivel(self, novo_combustivel):
        if type(novo_combustivel) == tipo_combustivel:
            self._combustivel = novo_combustivel
        else:
            print("Tipo de combustível inválido.")

    def __str__(self):
        return "Combustivel: {} - Valor do Litro: {} - Estoque: {}l".format(self._combustivel.name, super().valor,
                                                                            super().quantidade)
