
# Declarando e inicializando uma variável
f = 0
print(f)

# declarando a mesma variável novamente
f = "abc"
print(f)

# Gerando um erro, tentando unir variáveis de tipos diferentes
print("texto com tipos diferentes " + str(123))

# Variável Global X Variável local


def Funcao():
    global f
    f = 'variavel local'
    print(f)


Funcao()
print(f)