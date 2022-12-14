#
# Escrevendo arquivos com funções do Python
#
def EscreveArquivo():
    arquivo = open("NovoArquivo.txt", 'w+')

    arquivo.write("Linha gerada com a função escreve arquivo.")

    arquivo.close()

#EscreveArquivo()

def AlteraArquivo():
    arquivo = open("NovoArquivo.txt", 'a')

    arquivo.write("Linha gerada com a função altera arquivo.")

    arquivo.close()

AlteraArquivo()