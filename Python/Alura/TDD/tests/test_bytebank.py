import pytest
from pytest import mark

from codigo.bytebank import Funcionario


class Testes:
    @mark.calcular_idade
    def test_passando_a_data_13_08_2000_deve_retornar_23(self):
        funcionario = Funcionario("Guilherme", "13/05/2000", 1000)
        idade = funcionario.idade()
        esperado = 23

        assert idade == esperado

    @mark.calcular_decrescimo
    def test_passado_um_decrescimo_salario_de_100000_deve_retornar_90000(self):
        nome_entrada = "José Silva"
        salario = 100000
        esperado = 90000

        funcionario_teste = Funcionario(nome_entrada, "07/05/1994", salario)
        funcionario_teste.decrescimo_salario()

        assert funcionario_teste.salario == esperado

    @mark.calcular_bonus
    def test_salario_1000_deve_receber_um_bonus_de_100(self):
        nome_entrada = "Ana Maria"
        salario = 1000
        esperado = 100
        funcionario_teste = Funcionario(nome_entrada, "07/05/1994", salario)

        assert funcionario_teste.calcular_bonus() == esperado

    @mark.retornar_erro
    def test_salario_alto_deve_retornar_erro_ao_receber_bonus(self):
        with pytest.raises(Exception):
            nome_entrada = "Ana Maria"
            salario = 10000000
            funcionario_teste = Funcionario(nome_entrada, "07/05/1994", salario)

            assert funcionario_teste.calcular_bonus()
