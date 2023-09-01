from Conta import *

conta1 = Conta(123, "Guilherme", 1000, 50000)
conta2 = Conta(124, "Pedro", 2000, 55000)

#conta1.depositar(1)
#conta1.sacar(1800)

conta1.transferir(500, conta2)
conta2.limite = 5000
print(conta2.limite)