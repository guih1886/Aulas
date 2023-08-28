import random


def jogar():
    print(25*"*")
    print("Bem vindo ao jogo de adivinhação")
    print(25*"*")

    numero_secreto = random.randrange(0, 10)
    total_tentativas = 0
    print(numero_secreto)

    print("Selecione a dificuldade: ")
    nivel = int(input("(1) Fácil - (2) Médio - (3) Difícil: "))

    if nivel == 1:
        total_tentativas = 20
    elif nivel == 2:
        total_tentativas = 10
    elif nivel == 3:
        total_tentativas = 5

    for tentativa in range(1, total_tentativas + 1):
        print("Tentativa {} de {}: ".format(tentativa, total_tentativas))
        chute = input("Digite o seu palpite: ")

        if (int(chute) == numero_secreto):
            print("Você acertou!")
            break
        else:
            print("Você errou.")
            if (int(chute) < numero_secreto):
                print("O número secreto é maior.")
            else:
                print("O número secreto é menor.")

    print("Fim de jogo.")


if (__name__ == "__main__"):
    jogar()
