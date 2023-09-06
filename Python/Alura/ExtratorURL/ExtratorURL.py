class ExtratorUrl:
    def __init__(self, url):
        self.url = self.sanitiza_url(url)
        self.valida_url()

    def sanitiza_url(self, url):
        if url == str:
            return url.strip()
        else:
            self.url = ""

    def valida_url(self):
        if not self.url:
            raise ValueError("A URL está vazia.")

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


extrator = ExtratorUrl(None)
resultado = extrator.get_valor_parametro("moedaOrigem")
print(resultado)
