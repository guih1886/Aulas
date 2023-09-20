# Exercicio Invoice, simulador de loja. Com os atributos do número do item da fa-
# tura, descrição do item, quantidade e preço unitario. O método getInvoiceAmount
# retorna o valor da compra.
from invoce import Invoice

produtos = {
    (1, "Computador Bom", 5, 1600.99),
    (2, "Teclado Excelente", 2, 35.99),
    (3, "Mouse Bom", 2, 80.99),
    (4, "Monitor", 3, 150),
}

carrinho = Invoice(produtos)
carrinho.getInvoiceAmount()
