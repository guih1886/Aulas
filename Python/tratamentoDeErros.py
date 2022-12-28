try:
    a = int(input("Digite um valor: "))
    b = int(input("Digite um dividendo: "))
    r = a / b
except ZeroDivisionError:
    print("Não é possivel dividir por zero.")
except (ValueError, TypeError):
    print("Problema com os dados digitados.")
else:
    print(f"O resultado é : {r}")
finally:
    print("Isso mostra sempre.")
