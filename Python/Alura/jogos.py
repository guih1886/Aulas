import forca
import adivinhacao

print(25*"*")
print("Escolha seu jogo")
print(25*"*")

jogo = int(input("(1) Forca - (2) Adivinhação: "))

if jogo == 1:
    forca.jogar()
elif jogo == 2:
    adivinhacao.jogar()
else:
    print("Opção inválida.")
