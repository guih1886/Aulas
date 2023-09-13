# Exercicio conta corrente, criar uma classe onde contenha os atributos número da
# conta, nome do correntista e saldo. Com métodos para alterar o nome, depósito e
# saque.

from conta_corrente import conta_corrente

minha_conta = conta_corrente(0o1, "Guilherme Henrique")
minha_conta.depositar(100.50)
minha_conta.sacar(82.72)
minha_conta.sacar(82.72)

print(minha_conta)

minha_conta.alterar_correntista("Pedro Maria")
print(minha_conta)
