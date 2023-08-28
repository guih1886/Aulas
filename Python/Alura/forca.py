def jogar():
    print(25*"*")
    print("Bem vindo ao jogo da forca")
    print(25*"*")

    palavra_secreta = "banana"
    enforcou = False
    acertou = False

    while (not enforcou and not acertou):
        chute = input("Qual letra?: ")
        palavra_secreta.find(chute)
        print("jogando...")

    print("Fim do jogo")


if (__name__ == '__main__'):
    jogar()
