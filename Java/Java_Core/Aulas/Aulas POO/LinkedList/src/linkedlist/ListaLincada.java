package linkedlist;

import java.util.LinkedList;

public class ListaLincada {

    public static void main(String[] args) {
        LinkedList<String> car = new LinkedList<>();

        //POPULANDO A LISTA
        car.add("Palio");
        car.add("Gol");
        car.add("Clio");

        //PEGANDO O PRIMEIRO E ULTIMO INDICE
        System.out.println(car);
        System.out.println(car.getFirst());
        System.out.println(car.getLast());

        //ADICIONANDO NO PRIMEIRO E ULTIMO INDICE
        car.addFirst("Sandero");
        car.addLast("Punto");
        System.out.println(car);

        //REMOVENDO O PRIMEIRO E ULTIMO INDICE
        car.removeFirst();
        car.removeLast();
        System.out.println(car);
    }

}
