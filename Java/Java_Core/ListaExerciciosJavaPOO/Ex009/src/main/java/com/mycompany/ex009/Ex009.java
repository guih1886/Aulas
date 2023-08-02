package com.mycompany.ex009;

/*

Exercicio do voo, aonde a classe possui os atributos de número do voo e a data.
Possui os métodos para verificar a próxima cadeira livre, verificar se um asse-
to está ocupado, ocupar para reservar um lugar, verificar a quantidade de vagas
disponíveis e um método que retorno o número do voo.

 */
import java.text.ParseException;

public class Ex009 {

    public static void main(String[] args) throws ParseException {
        Voo voo1 = new Voo(105, "23/03/2023");
        voo1.ocupa(1);
        voo1.ocupa(2);
        voo1.ocupa(3);
        voo1.ocupa(4);

        voo1.proximoLivre();
        voo1.verifica(3);
        voo1.vagas();
        voo1.getVoo();
    }
}
