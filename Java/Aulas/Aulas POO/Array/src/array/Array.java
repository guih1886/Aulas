package array;

import javax.swing.JOptionPane;

public class Array {

    public static void main(String[] args) {
        String[] paises = new String[4];
        int[] numeros = new int[4];

        for (int i = 0; i < paises.length; i++) {
            paises[i] = JOptionPane.showInputDialog("Digite o país " + i + ": ");
        }

        for (String lista : paises) {
            System.out.println(lista);
        }

        for (int i = 0; i < numeros.length; i++) {
            numeros[i] = Integer.parseInt(JOptionPane.showInputDialog("Digite"
                    + " o país " + i + ": "));
        }
        for (int lista : numeros) {
            System.out.println(lista);
        }
    }

}
