package leiloes;

import login.LoginPage;
import org.junit.Assert;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;

public class LeiloesTest {
    private LeiloesPage paginaLeiloes;
    private CadastroLeilaoPage paginaDeCadastroDeLeilao;

    @BeforeEach
    public void beforeEach() {
        LoginPage paginaDeLogin = new LoginPage();
        this.paginaLeiloes = paginaDeLogin.efetuarLogin("fulano", "pass");
        this.paginaDeCadastroDeLeilao = paginaLeiloes.carregarFormulario();
    }

    @AfterEach
    public void afterEach() {
        this.paginaLeiloes.fechar();
        this.paginaDeCadastroDeLeilao.fechar();
    }

    @Test
    public void deveriaCadastrarLeilao() {
        String hoje = LocalDate.now().format(DateTimeFormatter.ofPattern("dd/MM/yyyy"));
        String nomeLeilao = "Leilao do dia " + hoje;
        String valorInicial = "500.00";
        this.paginaLeiloes = paginaDeCadastroDeLeilao.cadastrarLeilao(nomeLeilao, valorInicial, hoje);
        Assert.assertTrue(paginaLeiloes.isLeilaoCadastrado(nomeLeilao, valorInicial, hoje));
    }

    @Test
    public void deveriaValidarCadastroDeLeilao() {
        this.paginaLeiloes = paginaDeCadastroDeLeilao.cadastrarLeilao("", "", "");
            Assert.assertFalse(paginaDeCadastroDeLeilao.isPaginaAtual());
            Assert.assertTrue(paginaLeiloes.isPaginaAtual());
            Assert.assertTrue(paginaDeCadastroDeLeilao.mensagemDeValidacaoVisivel());

    }
}
