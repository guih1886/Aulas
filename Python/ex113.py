def leiaInt(msg):
    while True:
        try:
            n = int(input(msg))
        except (ValueError, TypeError):
            print(
                "\033[31m Erro: por favor digite um número inteiro válido. \033[m")
        else:
            return n


num = leiaInt("Digite um valor: ")
print(f'{num}')
