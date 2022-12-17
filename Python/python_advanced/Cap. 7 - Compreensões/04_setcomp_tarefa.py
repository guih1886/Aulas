# Usando set comprehensions


def main():
    # Definindo uma lista de temperaturas
    ctemps = [5, 10, 12, 14, 10, 23, 41, 30, 12, 24, 12, 18, 29]

    # TODO: Crie um set com as temperaturas em Fahrenheit
    # Dica: Fórmula pra converter para Fahrenheit -> (t * 9/5) + 32
    ftemp_lista = [(t * 9/5) + 32 for t in ctemps]
    # sets nao contem duplicidade por os valores são únicos
    ftemp_sets = {(t * 9/5) + 32 for t in ctemps}
    print(ftemp_lista, ftemp_sets)

    # TODO: Crie um set a partir de uma string
    frase = 'Uma frase de exemplo'
    letras = {l.upper() for l in frase if not l.isspace()}
    print(letras)


if __name__ == "__main__":
    main()
