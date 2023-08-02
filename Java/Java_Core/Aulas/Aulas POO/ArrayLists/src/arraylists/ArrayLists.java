package arraylists;

import java.util.ArrayList;

public class ArrayLists {

    public static void main(String[] args) {
        ArrayList<String> carros = new ArrayList<>();

        //POPULANDO A LISTA
        carros.add("Cruze");
        carros.add("Golf");
        carros.add("Corolla");
        carros.add("Civic");
        System.out.println(carros);

        //ALTERANDO A LISTA E CONSULTANDO O VALOR
        carros.set(3, "Fiat 147");
        System.out.println(carros);
        System.out.println(carros.size());

        //PROCURANDO E EXCLUINDO NA LISTA
        if (carros.contains("Golf")) {
            for (int i = 0; i < carros.size(); i++) {
                if ("Golf".equals(carros.get(i))) {
                    carros.set(i, "Uno");
                }
            }
        } else {
            System.out.println("Não contém na lista.");
        }
        System.out.println(carros);

        carros.remove(0);
        System.out.println(carros);
        carros.clear();
        System.out.println(carros);
    }

}
