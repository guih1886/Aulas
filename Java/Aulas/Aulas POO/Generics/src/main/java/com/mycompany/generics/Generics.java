package com.mycompany.generics;

import javax.swing.JOptionPane;

public class Generics {

    public static void main(String[] args) {
        //exemplo de uso de generics

        String nome = JOptionPane.showInputDialog("Informe o nome do"
                + " avião: ");
        String numeroAeronave = JOptionPane.showInputDialog("Infome o "
                + "número da aeronave: ");

        //na declaração do da instancia é informado o tipo da classe
        Aeronave<String> aviao = new Aeronave<>(nome, numeroAeronave);

        System.out.println(aviao.getNome());
        System.out.println(aviao.getNumeroAeronave());
        
        //método com anotação deprecated, executa de toda forma
        System.out.println(aviao.deprecated());
    }
}
