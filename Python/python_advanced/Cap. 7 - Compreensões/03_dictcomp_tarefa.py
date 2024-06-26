# Usando dict comprehensions


def main():
    # Definindo uma lista de temperaturas
    ctemps = [0, 12, 34, 100]

    # TODO: Use a comprehension to build a dictionary
    # Dica: Fórmula pra converter para Fahrenheit -> (t * 9/5) + 32
    dicio_temp = {t: (t * 9/5) + 32 for t in ctemps if t < 100}
    print(dicio_temp)
    print(dicio_temp[12])

    # Definindo dois times
    time_a = {"João": 24, "Jessica": 18, "Gustavo": 58, "Barbara": 7}
    time_b = {"Leticia": 12, "Gabriel": 88, "José": 4}
    times = (time_a, time_b)

    # Combinando dois dicionários com uma comprehension
    novo_time = {k: v for time in times for k, v in time.items()}
    print(novo_time)


if __name__ == "__main__":
    main()
