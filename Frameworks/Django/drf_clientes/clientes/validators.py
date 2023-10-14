import re
from validate_docbr import CPF


def cpf_valido(numero_cpf):
    cpf = CPF()
    return cpf.validate(numero_cpf)


def nome_valido(nome):
    return re.match("^[A-Za-z ]+$", nome)


def rg_valido(rg):
    return len(rg) == 9


def celular_valido(celular):
    """ Verifica de celular é válido (xx) xxxxx-xxxx"""
    regex = r'^\(?[1-9]{2}\)?\s?9[0-9]{4}-[0-9]{4}$'
    return re.match(regex, celular)
