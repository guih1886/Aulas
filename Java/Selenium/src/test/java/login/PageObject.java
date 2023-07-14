package login;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

import java.util.concurrent.TimeUnit;

public class PageObject {
    protected WebDriver browser;

    public PageObject(WebDriver browser) {
        System.setProperty("webdriver.chrome.driver", "src/drivers/chromedriver.exe");
        if (browser != null) {
            this.browser = browser;
        } else {
            this.browser = new ChromeDriver();
        }

        browser.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS).pageLoadTimeout(10, TimeUnit.SECONDS);
    }

    public void fechar() {
        this.browser.quit();
    }
}
