package login;

import org.junit.Assert;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

public class LoginTest {

    private LoginPage paginaLogin;

    @BeforeEach
    public void beforeEach() {
        this.paginaLogin = new LoginPage();
    }

    @AfterEach
    public void afterEach() {
        this.paginaLogin.fechar();
    }

    @Test
    public void deveriaEfetuarLoginComDadosValidos() {
        paginaLogin.efetuarLogin("fulano", "pass");
        Assert.assertFalse(paginaLogin.isPaginaLogin());
        Assert.assertEquals("fulano", paginaLogin.getNomeUsuarioLogado());
    }

    @Test
    public void naoDeveriaEfetuarLoginComDadosInvalidos() {
        paginaLogin.efetuarLogin("invalido", "pass");
        Assert.assertTrue(paginaLogin.isPaginaLoginInvalido());
        Assert.assertNull(paginaLogin.getNomeUsuarioLogado());
        Assert.assertTrue(paginaLogin.contemTexto("Usuário e senha inválidos."));
    }

    @Test
    public void naoDeveriaAcessarPaginaRestritaSemLogar() {
        paginaLogin.navegaParaPaginaDeLances();
        Assert.assertTrue(paginaLogin.isPaginaLogin());
        Assert.assertFalse(paginaLogin.contemTexto("Dados do leilão."));
    }
}
