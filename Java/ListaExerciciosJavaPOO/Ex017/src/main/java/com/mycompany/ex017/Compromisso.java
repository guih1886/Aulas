package com.mycompany.ex017;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.Scanner;

public class Compromisso {
    private int id = 0;
    private Date data;
    private String nomeParticipante;
    private String participante;
    private String telefoneParticipante;
    private TipoCompromisso tipoCompromisso;
    private SimpleDateFormat sf = new SimpleDateFormat("dd/MM/yyyy");
    private List<Compromisso> compromissos = new ArrayList<>();
    private int option;
    Scanner leitor = new Scanner(System.in);

    public void start() throws ParseException {
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
                limparTela();
                cadastrarCompromisso();
                adicionarCompromisso(sf.format(this.data), this.nomeParticipante, this.participante,
                        this.telefoneParticipante,
                        this.tipoCompromisso);
                System.out.println("Compromisso adicionado com sucesso.");
                start();
                break;
            case 2:
                limparTela();
                listarCompromissos();
                System.out.print("Informe o id do compromisso que deseja alterar: ");
                this.option = leitor.nextInt();
                alterarCompromisso(this.option);
                start();
                break;
            // remove o compromisso
            case 3:
                limparTela();
                listarCompromissos();
                System.out.print("Informe o id do compromisso que deseja excluir: ");
                this.option = leitor.nextInt();
                removerCompromisso(this.option);
                start();
                break;
            // lista os compromissos
            case 4:
                limparTela();
                listarCompromissos();
                start();
                break;
            case 5:
                break;
            default:
                System.out.println("Opção inválida");
                // limpa o terminal
                limparTela();
                start();
                break;
        }
    }

    private void cadastrarCompromisso() throws ParseException {
        System.out.print("Digite a data dd/mm/yyyy: ");
        this.data = sf.parse(leitor.next());
        System.out.print("Digite o participante: ");
        this.nomeParticipante = leitor.next();
        System.out.print("Digite o quem participará do evento: ");
        this.participante = leitor.next();
        System.out.print("Digite o contato participante: ");
        this.telefoneParticipante = leitor.next();
        System.out.println("Digite o tipo do compromisso 1 - Reuniao | 2 - Pagamento: ");
        System.out.print("--------------------------------- 3 - Entrega de projeto: ");
        this.option = leitor.nextInt();
        if (this.option == 1) {
            this.tipoCompromisso = TipoCompromisso.Reuniao;
        }
        if (this.option == 2) {
            this.tipoCompromisso = TipoCompromisso.Pagamento;
        }
        if (this.option == 3) {
            this.tipoCompromisso = TipoCompromisso.Entrega_de_projeto;
        }
    }

    private void alterarCompromisso(int option) throws ParseException {
        for (Compromisso compromisso : compromissos) {
            if (compromisso.getId() == option) {
                cadastrarCompromisso();
                compromisso.setData(this.data);
                compromisso.setNomeParticipante(this.nomeParticipante);
                compromisso.setParticipante(this.participante);
                compromisso.setTelefoneParticipante(this.telefoneParticipante);
                compromisso.setTipoCompromisso(this.tipoCompromisso);
                System.out.println("Compromisso adicionado com sucesso.");
                return;
            }
        }
        System.out.println("Compromisso não encontrado na lista.");
    }

    private void removerCompromisso(int option) {
        for (int i = 0; i < compromissos.size(); i++) {
            if (compromissos.get(i).getId() == option) {
                compromissos.remove(i);
                System.out.println("Compromisso removido com sucesso.");
                return;
            }
        }
        System.out.println("Compromisso não encontrado.");
    }

    public Compromisso(int id, String data, String participante, String nomeParticipante, String telefoneParticipante,
            TipoCompromisso tipoCompromisso) throws ParseException {
        this.id = id;
        this.data = sf.parse(data);
        this.nomeParticipante = nomeParticipante;
        this.participante = participante;
        this.telefoneParticipante = telefoneParticipante;
        this.tipoCompromisso = tipoCompromisso;
    }

    public Compromisso() {
    }

    public void adicionarCompromisso(String data, String nomeParticipante, String participante,
            String telefoneParticipante,
            TipoCompromisso tipoCompromisso) throws ParseException {
        id++;
        // adicionando objetos à lista
        compromissos
                .add(new Compromisso(this.id, data, participante, nomeParticipante, telefoneParticipante,
                        tipoCompromisso));

    }

    public void listarCompromissos() throws ParseException {
        if (compromissos.size() == 0) {
            System.out.println("Nenhum compromisso foi adicionado ainda.");
            start();

        } else {
            for (Compromisso c : compromissos) {
                System.out.println("-----------------------------------------------------");
                System.out.println("ID: " + c.getId());
                System.out.println("Data: " + c.getData());
                System.out.println("Nome do participante: " + c.getNomeParticipante());
                System.out.println("Participante: " + c.getParticipante());
                System.out.println("Telefone do participante: " + c.getTelefoneParticipante());
                System.out.println("Tipo do compromisso: " + c.getTipoCompromisso());
                System.out.println("-----------------------------------------------------");
            }
        }
    }

    public void limparTela() {
        System.out.print("\033[H\033[2J");
    }

    public int getId() {
        return id;
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

    public void setId(int id) {
        this.id = id;
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
