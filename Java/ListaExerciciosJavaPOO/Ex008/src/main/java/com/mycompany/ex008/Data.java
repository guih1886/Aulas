package com.mycompany.ex008;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;

public class Data {

    private Date data;

    public Data(String data) throws ParseException {
        SimpleDateFormat sf = new SimpleDateFormat("dd/MM/yyyy");
        if (data.matches("^(0?[1-9]|[12][0-9]|3[01])[\\/\\-](0?[1-9]|1[012])[\\/\\-]\\d{4}$")) {
            Date date = sf.parse(data);
            this.data = date;
        } else {
            this.data = sf.parse("01/01/0001");
        }
    }

    public int compara() {
        //pegando a data atual
        LocalDate atual = LocalDate.now();
        LocalDate atualData = LocalDate.of(getAno(), getMes(), getDia());

        //comparação das datas
        if (atual.isEqual(atualData)) {
            return 0;
        } else if (atual.isAfter(atualData)) {
            return 1;
        } else {
            return -1;
        }

    }

    public int getDia() {
        Calendar calendario = new GregorianCalendar();
        calendario.setTime(this.data);
        int dia = calendario.get(Calendar.DAY_OF_MONTH);
        return dia;
    }

    public int getMes() {
        Calendar calendario = new GregorianCalendar();
        calendario.setTime(this.data);
        int mes = calendario.get(Calendar.MONTH);
        return mes + 1;
    }

    public void getMesExtenso() {
        Calendar calendario = new GregorianCalendar();
        calendario.setTime(this.data);
        int mes = calendario.get(Calendar.MONTH);
        switch (mes + 1) {
            case 1:
                System.out.println("Janeiro");
                break;
            case 2:
                System.out.println("Fevereiro");
                break;
            case 3:
                System.out.println("Março");
                break;
            case 4:
                System.out.println("Abril");
                break;
            case 5:
                System.out.println("Maio");
                break;
            case 6:
                System.out.println("Junho");
                break;
            case 7:
                System.out.println("Julho");
                break;
            case 8:
                System.out.println("Agosto");
                break;
            case 9:
                System.out.println("Setembro");
                break;
            case 10:
                System.out.println("Outubro");
                break;
            case 11:
                System.out.println("Novembro");
                break;
            case 12:
                System.out.println("Dezembro");
                break;
        }
    }

    public int getAno() {
        Calendar calendario = new GregorianCalendar();
        calendario.setTime(this.data);
        int ano = calendario.get(Calendar.YEAR);
        return ano;
    }

    public boolean isBissexto() {
        Calendar cal = new GregorianCalendar();
        cal.getTime();
        int anoAtual = cal.get(Calendar.YEAR);
        if (anoAtual % 4 != 0 && anoAtual % 400 != 0) {
            return false;
        } else {
            return true;
        }
    }

    public void clone(String newData) throws ParseException {
        Data dClone = new Data(newData);
        System.out.println(dClone.compara());
        System.out.println(dClone.getDia());
        System.out.println(dClone.getMes());
        System.out.println(dClone.getAno());
        dClone.getMesExtenso();
        System.out.println(dClone.isBissexto());

    }

}
