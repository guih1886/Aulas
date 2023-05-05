package com.mycompany.ex017;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.Scanner;

public class Compromisso {
    private Date data;
    private String nomeParticipante;
    private String participante;
    private String telefoneParticipante;
    private TipoCompromisso tipoCompromisso;
    private SimpleDateFormat sf = new SimpleDateFormat("dd/MM/yyyy");
    static List<Compromisso> compromissos = new ArrayList<>();
    private int option;
    Scanner leitor = new Scanner(System.in);

    public void start() {
        // inicio do sistema
        System.out.println("-------- Sistema Gerenciador de Compromissos --------");
        System.out.println("-----------------------------------------------------");
        System.out.println("Digite a opção para continuar");
        System.out.println("1 - Agendar | 2 - Alterar | 3 - Remover | 4 - Listar");
        System.out.println("                        5 - Sair                         ");
        System.out.print("Opção: ");
        this.option = leitor.nextInt();

        switch (this.option) {
            case 1:
                System.out.print("Digite o participante: ");
                break;
            case 2:
                // alterar
                break;
            case 3:
                // remover
                break;
            case 4:
                listarCompromissos();
                break;
            case 5:
                break;
            default:
                System.out.println("Opção inválida");
                // limpa o terminal
                System.out.print("\033[H\033[2J");
                System.out.flush();
                start();
                break;
        }
    }

    public Compromisso(String data, String nomeParticipante, String participante, String telefoneParticipante,
            TipoCompromisso tipoCompromisso) throws ParseException {
        this.data = sf.parse(data);
        this.nomeParticipante = nomeParticipante;
        this.participante = participante;
        this.telefoneParticipante = telefoneParticipante;
        this.tipoCompromisso = tipoCompromisso;
    }

    public Compromisso() {
    }

    public static void adicionarCompromisso(String data, String nomeParticipante, String participante,
            String telefoneParticipante,
            TipoCompromisso tipoCompromisso) throws ParseException {
        // adicionando objetos à lista
        compromissos.add(new Compromisso(data, nomeParticipante, participante, telefoneParticipante, tipoCompromisso));

    }

    public void listarCompromissos() {
        if (compromissos.size() == 0) {
            System.out.println("Nenhum compromisso foi adicionado ainda.");
            start();

        } else {
            for (Compromisso c : compromissos) {
                System.out.println("Data: " + c.getData());
                System.out.println("Nome do participante: " + c.getNomeParticipante());
                System.out.println("Participante: " + c.getParticipante());
                System.out.println("Telefone do participante: " + c.getTelefoneParticipante());
                System.out.println("Tipo do compromisso: " + c.getTipoCompromisso());
            }
        }
    }

    public String getData() {
        return sf.format(this.data);
    }

    public String getNomeParticipante() {
        return nomeParticipante;
    }

    public String getParticipante() {
        return participante;
    }

    public String getTelefoneParticipante() {
        return telefoneParticipante;
    }

    public TipoCompromisso getTipoCompromisso() {
        return tipoCompromisso;
    }

    public void setData(Date data) {
        this.data = data;
    }

    public void setNomeParticipante(String nomeParticipante) {
        this.nomeParticipante = nomeParticipante;
    }

    public void setParticipante(String participante) {
        this.participante = participante;
    }

    public void setTelefoneParticipante(String telefoneParticipante) {
        this.telefoneParticipante = telefoneParticipante;
    }

    public void setTipoCompromisso(TipoCompromisso tipoCompromisso) {
        this.tipoCompromisso = tipoCompromisso;
    }

}
