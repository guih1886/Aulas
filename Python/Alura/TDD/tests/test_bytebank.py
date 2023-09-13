from codigo.bytebank import Funcionario


class Testes:
    def test_passando_a_data_13_08_2000_deve_retornar_23(self):
        funcionario = Funcionario("Guilherme", "13/05/2000", 1000)
        idade = funcionario.idade()
        esperado = 23

        assert idade == esperado
