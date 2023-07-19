package br.com.alura.leilao.acceptance.steps;

import br.com.alura.leilao.model.Lance;
import br.com.alura.leilao.model.Leilao;
import br.com.alura.leilao.model.Usuario;
import io.cucumber.datatable.DataTable;
import io.cucumber.java.Before;
import io.cucumber.java.en.Given;
import io.cucumber.java.en.Then;
import io.cucumber.java.en.When;
import io.cucumber.java.pt.Dado;
import io.cucumber.java.pt.Então;
import io.cucumber.junit.Cucumber;
import org.junit.Assert;
import org.junit.runner.RunWith;

import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;

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
        this.lance = new Lance(usuario, new BigDecimal("10"));
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

    @Dado("um lançe de {double} reais")
    public void dadoUmLanceDeInvalido(Double valor) {
        this.lance = new Lance(new BigDecimal(valor));
    }

    @Dado("dois lançes")
    public void dois_lançes(DataTable dataTable) {
        List<Map<String, String>> valores = dataTable.asMaps();
        for (Map<String, String> mapa : valores) {
            String valor = mapa.get("valor");
            String nome = mapa.get("nomeUsuario");
            Lance lance = new Lance(new Usuario(nome), new BigDecimal(valor));
            lista.add(lance);
        }
    }

    @Then("o lançe não é aceito")
    public void lanceNaoEAceito() {
        Assert.assertEquals(0, leilao.getLances().size());
    }

    @Então("o segundo lance não é aceito")
    public void o_segundo_lance_não_é_aceito() {
        Assert.assertEquals(1, leilao.getLances().size());
        Assert.assertEquals(this.lista.get(0).getValor(), leilao.getLances().get(0).getValor());
    }

}
