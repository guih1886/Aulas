from validate_docbr import CPF, CNPJ


class cpfCnpj:
    def __init__(self, documento, tipo_documento):
        self.tipo_documento = tipo_documento.lower()
        if self.tipo_documento == "cpf":
            if self.valida_cpf(documento):
                self.cpf = str(documento)
            else:
                raise ValueError("Cpf inválido.")
        if self.tipo_documento == "cnpj":
            documento = str(documento)
            if self.valida_cnpj(documento):
                self.cnpj = documento
            else:
                raise ValueError("Cnpj inválido.")

    def valida_cpf(self, cpf):
        validador = CPF()
        return validador.validate(str(cpf))

    def valida_cnpj(self, cnpj):
        validador = CNPJ()
        return validador.validate(cnpj)

    def formata_cpf(self):
        validador = CPF()
        return validador.mask(self.cpf)

    def formata_cnpj(self):
        validador = CNPJ()
        return validador.mask(self.cnpj)

    def __str__(self):
        if self.tipo_documento == "cnpj":
            return self.formata_cnpj()
        if self.tipo_documento == "cpf":
            return self.formata_cpf()

    @staticmethod
    def gerar_novo_cpf():
        validador = CPF()
        return validador.generate(True)

    @staticmethod
    def gerar_novo_cnpj():
        validador = CNPJ()
        return validador.generate(True)
