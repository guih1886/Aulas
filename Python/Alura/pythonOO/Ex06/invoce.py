class Invoice:
    def __init__(self, lista_produtos):
        self._lista_produtos = lista_produtos

    def getInvoiceAmount(self):
        valor_total = 0
        total_itens = 0
        for produto in self._lista_produtos:
            valor_total += produto[3]
            total_itens += 1
        valor_total = str(valor_total).replace(".", ",")
        print(f"Total de {total_itens} itens: R$ {valor_total}")
