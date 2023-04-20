package com.mycompany.ex017;

public class Reuniao {

    private int index;
    private String data;
    private String nomeParticipante;
    private String nomeConvidado;
    private String telefone;

    public Reuniao(int index, String data, String nomeParticipante, String nomeConvidado, String telefone) {
        this.index = index;
        this.data = data;
        this.nomeParticipante = nomeParticipante;
        this.nomeConvidado = nomeConvidado;
        this.telefone = telefone;
    }

    public int getIndex() {
        return index;
    }

    public String getData() {
        return data;
    }

    public String getNomeParticipante() {
        return nomeParticipante;
    }

    public String getNomeConvidado() {
        return nomeConvidado;
    }

    public String getTelefone() {
        return telefone;
    }

    @Override
    public String toString() {
        return "Reuniao{" + "index=" + index + ", data=" + data + ", nomeParticipante=" + nomeParticipante + ", nomeConvidado=" + nomeConvidado + ", telefone=" + telefone + '}';
    }
    
    

}
