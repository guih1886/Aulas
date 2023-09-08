import re


class ExtratorCEP:
    def __init__(self, endereco):
        self.endereco = endereco
        self.cep = ""

    def extrai_cep(self):
        padrao = re.compile("[0-9]{5}-?[0-9]{3}")
        busca = padrao.search(self.endereco)
        if busca:
            self.cep = busca.group()  # padrão achado no endereço (match)
            return self.cep
        else:
            print("Não foi encontrado um CEP no endereço informado.")


resultado = ExtratorCEP("Rua Luzia Dotta da Silva, 371 - 13880-000")
print(resultado.extrai_cep())
