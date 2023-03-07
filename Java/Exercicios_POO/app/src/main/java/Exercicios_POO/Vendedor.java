package Exercicios_POO;

import java.util.Date;

public class Vendedor extends Funcionario {

    private float comissaoPorItem;
    private int totalItensVendidos;

    public Vendedor() {
        super();
    }
    
    public float calcularSalario(){
        return super.getSalario() + (this.comissaoPorItem * this.totalItensVendidos);
    }

    public float getComissaoPorItem() {
        return comissaoPorItem;
    }

    public void setComissaoPorItem(float comissaoPorItem) {
        this.comissaoPorItem = comissaoPorItem;
    }

    public int getTotalItensVendidos() {
        return totalItensVendidos;
    }

    public void setTotalItensVendidos(int totalItensVendidos) {
        this.totalItensVendidos = totalItensVendidos;
    }

    void getDataNasc(Date date) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

}
