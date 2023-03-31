package com.mycompany.ex006;

/*

Exercicio Invoice, simulador de loja. Com os atributos do número do item da fa-
tura, descrição do item, quantidade e preço unitario. O método getInvoiceAmount
retorna o valor da compra.

 */
public class Ex006 {

    public static void main(String[] args) {
        Invoice inv = new Invoice(1, "Computador Dell", 5, 2599.35);
        Invoice inv2 = new Invoice(2, "Monitor 32''", 3, 799.99);
        Invoice inv3 = new Invoice(3, "Roteador", 2, 89.99);

        System.out.println(inv.getInvoiceAmount());
        System.out.println(inv2.getInvoiceAmount());
        System.out.println(inv3.getInvoiceAmount());
    }
}
