# Exercicio do elevador, com os atributos de andar atual, total de andares, capa-
# cidade do elevador e lotação. Possui os métodos para inicializar o elevador, en-
# trar, sair, subir e descer os andares.

from elevador import Elevador

elevador = Elevador(30, 8)
elevador.entrar(5)
elevador.entrar(3)
elevador.entrar(3)
elevador.sair(3)
elevador.sair(2)
elevador.sair(3)
elevador.entrar(3)
elevador.subir(10)
elevador.subir(1)
elevador.descer(11)
elevador.subir(2)
