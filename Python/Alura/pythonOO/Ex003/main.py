# Exercicio bomba de combustivel, que contem os atibutos tipo de combustivel, valor
# do litro e quantidade de combustivel. Possui os métodos para abastecer por valor,
# abastecer por litro, alterar valor, alterar tipo do combustivel e alterar a qua-
# ntidade de combustivel.
from bomba_combustivel import bomba_combustivel, tipo_combustivel

bomba_gasolina = bomba_combustivel(tipo_combustivel.DIESEL,5,50)
print(bomba_gasolina)
bomba_gasolina.alterar_valor_combustivel()
