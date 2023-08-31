from Conta import *

conta1 = Conta(123, "Guilherme", 1000, 50000)

conta1.depositar(1)
conta1.sacar(1800)

print(conta1.extrato())
