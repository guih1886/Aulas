import re


class validaTelefone:
    def __init__(self, contato):
        if self.valida(contato):
            self.telefone = contato
        else:
            raise ValueError("Número de telefone incorreto.")

    def valida(self, contato):
        pattern = re.compile("([\+]?[0-9]{2})?\s?([\(]?[0-9]{2}[\)]?)\s?([0-9]{4,5})[-]?([0-9]{4})")
        result = re.match(pattern, contato)
        return result

    def __str__(self):
        pattern = re.compile("([\+]?[0-9]{2})?\s?([\(]?[0-9]{2}[\)]?)\s?([0-9]{4,5})[-]?([0-9]{4})")
        result = re.match(pattern, self.telefone)
        if result.group(1):
            return "+{} ({}){}-{}".format(result.group(1),result.group(2),result.group(3),result.group(4))
