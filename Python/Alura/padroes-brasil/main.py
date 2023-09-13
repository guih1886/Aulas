from cpf_cnpj import cpfCnpj
from telefones import validaTelefone

exemplo_cpf = '69079764124'
exemplo_cnpj = '01456072000100'

meu_cpf = cpfCnpj(exemplo_cpf, "cpf")
meu_cnpj = cpfCnpj(exemplo_cnpj, "cnpj")

print(meu_cpf)
print(meu_cnpj)

print("Novo CPF: ", cpfCnpj.gerar_novo_cpf())
print("Novo CNPJ: ", cpfCnpj.gerar_novo_cnpj())

telefone = validaTelefone("5519982210064")
print(telefone)
