package leiloes;

import login.PageObject;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;

public class CadastroLeilaoPage extends PageObject {

    private static final String URL_LEILOES = "http://localhost:8080/leiloes/new";

    public CadastroLeilaoPage(WebDriver browser) {
        super(browser);
    }

    public LeiloesPage cadastrarLeilao(String nome, String valor, String data) {
        browser.findElement(By.id("nome")).sendKeys(nome);
        browser.findElement(By.id("valorInicial")).sendKeys(valor);
        browser.findElement(By.id("dataAbertura")).sendKeys(data);
        browser.findElement(By.id("button-submit")).click();
        return new LeiloesPage(browser);
    }

    public boolean isPaginaAtual() {
        return browser.getCurrentUrl().equals(URL_LEILOES);
    }

    public boolean mensagemDeValidacaoVisivel() {
        String pageSource = browser.getPageSource();
        return pageSource.contains("minimo 3 caracteres") &&
                pageSource.contains("não deve estar em branco") &&
                pageSource.contains("deve ser um valor maior de 0.1") &&
                pageSource.contains("deve ser uma data no formato dd/MM/yyyy");
    }
}
