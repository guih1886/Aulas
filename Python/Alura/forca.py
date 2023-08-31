import random


def jogar():

    imprime_mensagem_abertura()

    palavra_secreta = carrega_palavra_secreta()

    letras_acertadas = inicializa_letras_acertadas(palavra_secreta)

    enforcou = False
    acertou = False
    erros = 0

    while (not enforcou and not acertou):
        chute = input("Qual letra?: ")
        chute = chute.strip().upper()

        index = 0
        for letra in palavra_secreta:
            if letra == chute:
                letras_acertadas[index] = letra
            index += 1
        erros += 1

        print(letras_acertadas, "\n")
        enforcou = erros == 6
        acertou = "_" not in letras_acertadas

    if acertou:
        print("Você ganhou")
    else:
        print("Fim do jogo")


def imprime_mensagem_abertura():
    print(25*"*")
    print("Bem vindo ao jogo da forca")
    print(25*"*")


def carrega_palavra_secreta():
    palavras = []

    with open("C:\\Users\\guilh\\Documents\\GitHub\\Aulas\\Python\\Alura\\palavras.txt", "r") as arquivo:
        for linha in arquivo:
            palavras.append(linha.strip())

    numero = random.randrange(0, len(palavras))

    palavra_secreta = palavras[numero].upper()

    return palavra_secreta


def inicializa_letras_acertadas(palavra):
    return ["_" for letra in palavra]


if (__name__ == '__main__'):
    jogar()
