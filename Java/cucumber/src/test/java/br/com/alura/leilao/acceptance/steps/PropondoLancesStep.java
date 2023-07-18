package br.com.alura.leilao.acceptance.steps;

import br.com.alura.leilao.model.Lance;
import br.com.alura.leilao.model.Leilao;
import br.com.alura.leilao.model.Usuario;
import io.cucumber.java.Before;
import io.cucumber.java.en.Given;
import io.cucumber.java.en.Then;
import io.cucumber.java.en.When;
import io.cucumber.java.pt.Dado;
import org.junit.Assert;

import java.math.BigDecimal;
import java.util.ArrayList;

public class PropondoLancesStep {

    private Lance lance;
    private Leilao leilao;
    private ArrayList<Lance> lista;

    @Before
    public void setup() {
        this.lista = new ArrayList<Lance>();
        leilao = new Leilao("Computador Ótimo");
    }

    @Dado("um lançe valido")
    public void dadoLanceValido() {
        Usuario usuario = new Usuario("fulano");
        lance = new Lance(usuario, new BigDecimal("10"));
    }

    @When("propõe ao leilao")
    public void quandoPropoeOLance() {
        leilao.propoe(lance);
    }

    @Then("o lance é aceito")
    public void entaoOLanceEAceito() {
        Assert.assertEquals(1, leilao.getLances().size());
        Assert.assertEquals(BigDecimal.TEN, leilao.getLances().get(0).getValor());
    }

    @Dado("um lançe de {int} reais do usuario {string}")
    public void dadoVariosLancesValidos(Integer valor, String nomeUsuario) {
        Lance lance = new Lance(new Usuario(nomeUsuario), new BigDecimal(valor));
        lista.add(lance);
    }

    @When("propõe vários lançes ao leilao")
    public void quandoPropoeVariosLances() {
        this.lista.forEach(lance -> leilao.propoe(lance));
    }

    @Then("os lançes são aceitos")
    public void entaoOsLancesSaoAceitos() {
        Assert.assertEquals(this.lista.size(), leilao.getLances().size());
        Assert.assertEquals(this.lista.get(0).getValor(), leilao.getLances().get(0).getValor());
        Assert.assertEquals(this.lista.get(1).getValor(), leilao.getLances().get(1).getValor());

    }
}
