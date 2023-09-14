from posto_combustivel import PostoCombustivel
from tipo_combustivel import TipoCombustivel


class BombaCombustivel(PostoCombustivel):
    def __init__(self, combustivel: TipoCombustivel, valor_litro, quantidade_estoque):
        self._combustivel = combustivel
        super().__init__(valor_litro, quantidade_estoque)

    def alterar_tipo_combustivel(self, novo_combustivel: TipoCombustivel):
        self._combustivel = novo_combustivel
        print(f"Combustível altado para {novo_combustivel.name}")

    def abastecer_por_litro(self, litros):
        if litros > super().quantidade:
            print("Estoque insuficiente.")
        else:
            print(f"Abasteceu {litros}l e pagou R$ {round(litros * super().valor, 2)}")

    def __str__(self):
        return f"Combustivel: {self._combustivel.name} - Valor do Litro: R${round(super().valor, 2)} - Estoque: {super().quantidade}l"
