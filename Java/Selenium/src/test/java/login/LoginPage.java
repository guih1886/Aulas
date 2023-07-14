package login;

import leiloes.LeiloesPage;
import org.openqa.selenium.By;
import org.openqa.selenium.NoSuchElementException;

public class LoginPage extends PageObject {
    private static final String URL = "http://localhost:8080/login";

    public LoginPage() {
        super(null);
    }

    public LeiloesPage efetuarLogin(String username, String password) {
        browser.navigate().to(URL);
        browser.findElement(By.id("username")).sendKeys(username);
        browser.findElement(By.id("password")).sendKeys(password);
        browser.findElement(By.id("login-form")).submit();
        return new LeiloesPage(browser);
    }

    public boolean isPaginaLogin() {
        return browser.getCurrentUrl().equals(URL);
    }

    public String getNomeUsuarioLogado() {
        try {
            return browser.findElement(By.id("usuario-logado")).getText();
        } catch (NoSuchElementException e) {
            return null;
        }
    }

    public void navegaParaPaginaDeLances() {
        browser.navigate().to("http://localhost:8080/leiloes/2");
    }

    public boolean contemTexto(String texto) {
        return browser.getPageSource().contains(texto);
    }

    public boolean isPaginaLoginInvalido() {
        return browser.getCurrentUrl().equals(URL + "?error");
    }
}
