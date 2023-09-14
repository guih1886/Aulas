# Exercicio bomba de combustivel, que contem os atibutos tipo de combustivel, valor
# do litro e quantidade de combustivel. Possui os métodos para abastecer por valor,
# abastecer por litro, alterar valor, alterar tipo do combustivel e alterar a qua-
# ntidade de combustivel.


from bomba_combustivel import BombaCombustivel
from tipo_combustivel import TipoCombustivel

bomba_gasolina = BombaCombustivel(TipoCombustivel.DIESEL, 5, 50)
print(bomba_gasolina)
bomba_gasolina.alterar_tipo_combustivel(TipoCombustivel.GASOLINA)
bomba_gasolina.abastecer_por_valor(50)
bomba_gasolina.abastecer_por_valor(25)
print(bomba_gasolina)

print("-" * 30)

bomba_diesel = BombaCombustivel(TipoCombustivel.DIESEL, 2.89, 100)
bomba_diesel.alterar_valor_combustivel(6.89)
bomba_diesel.alterar_quantidade_estoque(200)
print(bomba_diesel)
print(bomba_diesel)
bomba_diesel.abastecer_por_litro(87.52)
