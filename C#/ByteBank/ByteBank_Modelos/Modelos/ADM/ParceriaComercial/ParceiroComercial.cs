using bytebank.Modelos.ADM.SistemaInterno;

namespace bytebank.Modelos.ADM.Utilitario
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        private AutenticacaoUtil autenticacao = new AutenticacaoUtil();
        public bool Autenticar(string senha)
        {
            return autenticacao.ValidarSenha(this.Senha, senha);
        }
    }
}
