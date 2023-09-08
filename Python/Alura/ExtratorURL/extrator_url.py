import re


class ExtratorUrl:
    def __init__(self, url_principal):
        self.url = self.sanitiza_url(url_principal)
        self.valida_url()

    def sanitiza_url(self, url_sanitiza):
        if type(url_sanitiza) == str:
            return url_sanitiza.strip()
        else:
            self.url = ""

    def valida_url(self):
        if not self.url:
            raise ValueError("A URL está vazia.")

        padrao_url = re.compile("(http(s)?://)?(www.)?bytebank.com(.br)?/cambio")
        match = padrao_url.match(self.url)
        if not match:
            raise ValueError("A URL é inválida.")

    def get_url_base(self):
        index_interrogacao = self.url.find("?")
        url_base = self.url[:index_interrogacao]
        return url_base

    def get_url_parametros(self):
        index_interrogacao = self.url.find("?")
        url_parametros = self.url[index_interrogacao + 1:]
        return url_parametros

    def get_valor_parametro(self, nome_parametro):
        indice_parametro = self.get_url_parametros().find(nome_parametro)
        indice_valor = indice_parametro + len(nome_parametro) + 1
        indice_e_comercial = self.get_url_parametros().find("&", indice_valor)

        if indice_e_comercial == -1:
            valor = self.get_url_parametros()[indice_valor:]
        else:
            valor = self.get_url_parametros()[indice_valor:indice_e_comercial]
        return valor

    def converte_dolar_em_real(self, valor_dolar):
        moeda_origem = extrator_url.get_valor_parametro("moedaOrigem")
        moeda_destino = extrator_url.get_valor_parametro("moedaDestino")
        quantidade = extrator_url.get_valor_parametro("quantidade")
        if moeda_origem == "real" and moeda_destino == "dolar":
            valor_conversao = int(quantidade) / VALOR_DOLAR
            print("O valor de R$" + quantidade + " reais é igual a $" + str(valor_conversao) + " dólares.")
        elif moeda_origem == "dolar" and moeda_destino == "real":
            valor_conversao = int(quantidade) * VALOR_DOLAR
            print("O valor de $" + quantidade + " dólares é igual a R$" + str(valor_conversao) + " reais.")
        else:
            print(f"Câmbio de {moeda_origem} para {moeda_destino} não está disponível.")

    def __len__(self):
        return len(self.url)

    def __str__(self):
        return ("Url: " + self.url + "\n" + "Parâmetros: " + self.get_url_parametros() + "\n" + "Url base: "
                + self.get_url_base()) + "\n" + "Tamanho da Url: " + str(self.__len__())


url = "bytebank.com/cambio?quantidade=100&moedaOrigem=dolar&moedaDestino=real"
extrator_url = ExtratorUrl(url)
VALOR_DOLAR = 5.50  # 1 dólar = 5.50 reais
extrator_url.converte_dolar_em_real(VALOR_DOLAR)



