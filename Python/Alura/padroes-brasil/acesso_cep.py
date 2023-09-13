import requests


class BuscaCep:
    def __init__(self, cep):
        self.json = None
        if self.cep_e_valido(cep):
            self.cep = cep
        else:
            raise ValueError("CEP inválido.")

    def cep_e_valido(self, cep):
        if len(cep) == 8:
            return True
        else:
            return False

    def formata_cep(self):
        return "{}-{}".format(self.cep[:5], self.cep[5:])

    def busca_cep(self):
        url = f"https://viacep.com.br/ws/{self.cep}/json/"
        res = requests.get(url)
        self.json = res.json()
        print(f"{self.json['logradouro']} - {self.json['bairro']} - {self.json['localidade']} - {self.json['uf']}")
