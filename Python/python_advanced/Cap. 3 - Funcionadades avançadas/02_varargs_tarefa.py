# Uso de argumentos variáveis


# TODO: Defina uma função que recebe argumentos variáveis
def adicao(*args):
    return sum(args)


def main():
    # TODO: Passe argumentos diferentes para o método adicao()
    print(adicao(5, 10, 15, 20))
    print(adicao(1, 2, 3))

    # TODO: Passe uma lista para o método adicao()
    valores = [10, 20, 30, 40]
    print(adicao(*valores))


if __name__ == "__main__":
    main()
