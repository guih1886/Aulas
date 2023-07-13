import org.junit.Assert;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.NoSuchElementException;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;


public class LoginTest {

    private static final String URL = "http://localhost:8080/login";
    private WebDriver browser;

    @BeforeAll
    public static void beforeAll() {
        System.setProperty("webdriver.chrome.driver", "src/drivers/chromedriver.exe");
    }

    @BeforeEach
    public void beaforeEach() {
        this.browser = new ChromeDriver();
        browser.navigate().to("http://localhost:8080/login");
    }

    @AfterEach
    public void afterEach() {
        this.browser.quit();
    }

    @Test
    public void deveriaEfetuarLoginComDadosValidos() {
        browser.findElement(By.id("username")).sendKeys("fulano");
        browser.findElement(By.id("password")).sendKeys("pass");
        browser.findElement(By.id("login-form")).submit();
        Assert.assertFalse(browser.getCurrentUrl().equals(URL));
        Assert.assertEquals("fulano", browser.findElement(By.id("usuario-logado")).getText());
    }

    @Test
    public void naoDeveriaEfetuarLoginComDadosInvalidos() {
        browser.findElement(By.id("username")).sendKeys("uhesioa");
        browser.findElement(By.id("password")).sendKeys("32656798");
        browser.findElement(By.id("login-form")).submit();
        Assert.assertTrue(browser.getCurrentUrl().equals(URL + "?error"));
        Assert.assertTrue(browser.getPageSource().contains("Usuário e senha inválidos."));
        Assert.assertThrows(NoSuchElementException.class, () -> browser.findElement(By.id("usuario-logado")));
    }
}
