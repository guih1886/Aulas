package br.com.alura.leilao.acceptance.steps;

import br.com.alura.leilao.e2e.pages.Browser;
import br.com.alura.leilao.e2e.pages.LeiloesPage;
import br.com.alura.leilao.e2e.pages.LoginPage;
import br.com.alura.leilao.e2e.pages.NovoLeilaoPage;
import io.cucumber.java.pt.Dado;
import io.cucumber.java.pt.Quando;
import io.cucumber.java.pt.Entao;
import org.junit.Assert;

public class LeilaoSteps {
    private LoginPage loginPage;
    private LeiloesPage leiloesPage;
    private NovoLeilaoPage novoLeilao;
    private Browser browser;

    @Dado("um usuario logado")
    public void um_usuario_logado() {
        browser = new Browser();
        browser.seed();
        loginPage = browser.getLoginPage();
        leiloesPage = loginPage.realizaLoginComoFulano();
    }

    @Quando("acessa a pagina de novo leilao")
    public void acessa_a_pagina_de_novo_leilao() {
        novoLeilao = leiloesPage.visitaPaginaParaCriarUmNovoLeilao();
    }

    @Quando("prenche o formulario com dados validos")
    public void prenche_o_formulario_com_dados_validos() {
        leiloesPage = novoLeilao.preencheForm("Computador Excelente", "8000", "18/07/2023");
    }

    @Entao("volta para a pagina de leiloes")
    public void volta_para_a_pagina_de_leiloes() {
        Assert.assertTrue(leiloesPage.estaNaPaginaDeLeiloes());
    }

    @Entao("o novo leilao aparece na tabela")
    public void o_novo_leilao_aparece_na_tabela() {
        Assert.assertTrue(leiloesPage.existe("Computador Excelente", "8000", "18/07/2023"));
        browser.clean();
    }
}
