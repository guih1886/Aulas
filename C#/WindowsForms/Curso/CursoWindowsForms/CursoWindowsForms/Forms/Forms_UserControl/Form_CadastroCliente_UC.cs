using CursoWindowsFormsBiblioteca;
using CursoWindowsFormsBiblioteca.Classes;
using CursoWindowsFormsBiblioteca.Databases;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Windows.Forms;

namespace CursoWindowsForms.Forms.Forms_UserControl
{
    public partial class Form_CadastroCliente_UC : UserControl
    {
        private Cliente.Unit ClienteUnit;
        public Form_CadastroCliente_UC()
        {
            ClienteUnit = new Cliente.Unit();
            InitializeComponent();
            Txt_NumeroCliente.Focus();
            Grp_Codigo.Text = "Código do Cliente";
            Grp_DadosPessoais.Text = "Dados pessoais";
            Grp_Endereco.Text = "Endereço";
            Grp_Outros.Text = "Outros dados";
            Lbl_Bairro.Text = "Bairro";
            Lbl_CEP.Text = "CEP";
            Lbl_Complemento.Text = "Complemento";
            Lbl_CPF.Text = "CPF";
            Lbl_Estado.Text = "Estado";
            Rdb_Masculino.Text = "Masculino";
            Rdb_Feminino.Text = "Feminino";
            Rdb_Indefinido.Text = "Indefinido";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_Cidade.Text = "Cidade";
            Lbl_NomeCliente.Text = "Nome";
            Lbl_NomeMae.Text = "Nome da Mãe";
            Lbl_NomePai.Text = "Nome do Pai";
            Lbl_Profissao.Text = "Profissão";
            Lbl_RendaFamiliar.Text = "Renda Familiar";
            Lbl_Telefone.Text = "Telefone";
            Ckb_TemPai.Text = "Pai desconhecido";
            Cmb_Estados.Items.AddRange(new object[] {
                "AC",
                "AL",
                "AP",
                "AM",
                "BA",
                "CE",
                "DF",
                "ES",
                "GO",
                "MA",
                "MT",
                "MS",
                "MG",
                "PA",
                "PB",
                "PR",
                "PE",
                "PI",
                "RJ",
                "RN",
                "RS",
                "RO",
                "RR",
                "SC",
                "SP",
                "SE",
                "TO"
            });

            Btn_Busca.Text = "Buscar";
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteUnit = LeituraForm();
                ClienteUnit.ValidaClasse();
                ClienteUnit.ValidaComplemento();
                ClienteUnit.IncluirFicharioSql();
                MessageBox.Show("Cliente incluso com sucesso.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparForm();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_NumeroCliente.Text == "")
            {
                MessageBox.Show("Insira um id para buscar o cliente.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit cliente = ClienteUnit.BuscarFicharioSql(Txt_NumeroCliente.Text);
                    PreencherForm(cliente);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_NumeroCliente.Text == "")
            {
                MessageBox.Show("Preencher um id válido.",
                "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    ClienteUnit = LeituraForm();
                    DialogResult result = MessageBox.Show($"Deseja realmente alterar o " +
                        $"cadastro do cliente {ClienteUnit.Nome}?", "ByteBank", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.OK)
                    {
                        ClienteUnit.AlterarFichario();
                        LimparForm();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void limparToolStripButton1_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void apagaToolStripButton2_Click(object sender, EventArgs e)
        {
            var clienteId = Txt_NumeroCliente.Text;
            if (clienteId != "")
            {
                try
                {
                    ClienteUnit = ClienteUnit.BuscarFichario(clienteId);
                    PreencherForm(ClienteUnit);
                    DialogResult result = MessageBox.Show($"Deseja realmente excluir o " +
                            $"cadastro do cliente {ClienteUnit.Nome}?", "ByteBank", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.OK)
                    {
                        ClienteUnit.ExcluirFichario();
                        LimparForm();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha um id para excluir.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PreencherForm(Cliente.Unit cliente)
        {
            Txt_NumeroCliente.Text = cliente.Id;
            Msk_CPF.Text = cliente.CPF;
            Txt_NomeCliente.Text = cliente.Nome;
            Txt_NomeMae.Text = cliente.NomeMae;
            Txt_NomePai.Text = cliente.NomePai;
            if (cliente.NaoTemPai == 1) Ckb_TemPai.Checked = true;
            if (cliente.Genero == 0) Rdb_Masculino.Checked = true;
            if (cliente.Genero == 1) Rdb_Feminino.Checked = true;
            if (cliente.Genero == 2) Rdb_Indefinido.Checked = true;
            Msk_CEP.Text = cliente.Cep;
            Txt_Logradouro.Text = cliente.Logradouro;
            Txt_Bairro.Text = cliente.Bairro;
            Txt_Cidade.Text = cliente.Cidade;
            Txt_Complemento.Text = cliente.Complemento;
            Cmb_Estados.SelectedItem = cliente.Estado;
            Txt_Telefone.Text = cliente.Telefone;
            Txt_Profissao.Text = cliente.Profissao;
            Txt_RendaFamiliar.Text = cliente.RendaFamiliar.ToString();
        }

        private Cliente.Unit LeituraForm()
        {
            ClienteUnit.Id = Txt_NumeroCliente.Text;
            ClienteUnit.CPF = Msk_CPF.Text.Replace(",", "").Replace(".", "").Replace("-", "").Trim();
            ClienteUnit.Nome = Txt_NomeCliente.Text;
            ClienteUnit.NomeMae = Txt_NomeMae.Text;
            ClienteUnit.NomePai = Txt_NomePai.Text;
            ClienteUnit.NaoTemPai = 0;
            if (Ckb_TemPai.Checked) ClienteUnit.NaoTemPai = 1;
            if (Rdb_Masculino.Checked) ClienteUnit.Genero = 0;
            if (Rdb_Feminino.Checked) ClienteUnit.Genero = 1;
            if (Rdb_Indefinido.Checked) ClienteUnit.Genero = 2;
            ClienteUnit.Cep = Msk_CEP.Text.Replace("-", "");
            ClienteUnit.Logradouro = Txt_Logradouro.Text;
            ClienteUnit.Bairro = Txt_Bairro.Text;
            ClienteUnit.Cidade = Txt_Cidade.Text;
            ClienteUnit.Complemento = Txt_Complemento.Text;
            ClienteUnit.Estado = Cmb_Estados.SelectedIndex != -1 ? Cmb_Estados.Items[Cmb_Estados.SelectedIndex].ToString() : "";
            ClienteUnit.Telefone = Txt_Telefone.Text;
            ClienteUnit.Profissao = Txt_Profissao.Text;
            ClienteUnit.RendaFamiliar = (Information.IsNumeric(Txt_RendaFamiliar.Text) && double.Parse(Txt_RendaFamiliar.Text) > 0) ?
                ClienteUnit.RendaFamiliar = double.Parse(Txt_RendaFamiliar.Text) :
                ClienteUnit.RendaFamiliar = 0;
            return ClienteUnit;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckb_TemPai.Checked)
            {
                Txt_NomePai.Text = "Pai desconhecido.";
                Txt_NomePai.Enabled = false;
            }
            else
            {
                Txt_NomePai.Text = "";
                Txt_NomePai.Enabled = true;
            }
        }

        private void Msk_CEP_Leave(object sender, EventArgs e)
        {
            string cep = Msk_CEP.Text.Replace("-", "").Trim();
            string vJson = Cls_Uteis.GeraJSONCEP(cep);
            Cep.Unit CEP = new Cep.Unit();
            CEP = Cep.DesSerializeClassUnit(vJson);

            if (vJson.Contains("logradouro"))
            {
                if (CEP.Logradouro != string.Empty) Txt_Logradouro.Enabled = false;
                Txt_Logradouro.Text = CEP.Logradouro;
                if (CEP.Bairro != string.Empty) Txt_Bairro.Enabled = false;
                Txt_Bairro.Text = CEP.Bairro;
                if (CEP.Localidade != string.Empty) Txt_Cidade.Enabled = false;
                Txt_Cidade.Text = CEP.Localidade;
                if (CEP.Complemento != string.Empty) Txt_Complemento.Enabled = false;
                Txt_Complemento.Text = CEP.Complemento;
                Cmb_Estados.SelectedIndex = Cmb_Estados.Items.IndexOf(CEP.UF.Normalize());
            }
            else
            {
                MessageBox.Show("CEP inválido", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LimparForm()
        {
            Txt_NumeroCliente.Text = string.Empty;
            Txt_Bairro.Text = string.Empty;
            Msk_CEP.Text = string.Empty;
            Txt_Complemento.Text = string.Empty;
            Msk_CPF.Text = string.Empty;
            Cmb_Estados.SelectedIndex = -1;
            Txt_Logradouro.Text = string.Empty;
            Txt_Cidade.Text = string.Empty;
            Txt_NomeCliente.Text = string.Empty;
            Txt_NomeMae.Text = string.Empty;
            Txt_NomePai.Text = string.Empty;
            Txt_Profissao.Text = string.Empty;
            Txt_RendaFamiliar.Text = string.Empty;
            Txt_Telefone.Text = string.Empty;
            Ckb_TemPai.Checked = false;
            Rdb_Feminino.Checked = false;
            Rdb_Indefinido.Checked = false;
            Rdb_Masculino.Checked = false;
            Txt_NumeroCliente.Focus();

            HabilitarCamposEndereco();
        }

        private void Pic_HabilitarEndereco_Click(object sender, EventArgs e)
        {
            HabilitarCamposEndereco();
        }

        private void HabilitarCamposEndereco()
        {
            Txt_Logradouro.Enabled = true;
            Txt_Bairro.Enabled = true;
            Txt_Cidade.Enabled = true;
            Txt_Complemento.Enabled = true;
        }

        private void Btn_Busca_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            //List<Cliente.Unit> lista = new List<Cliente.Unit>();
            List<List<string>> listaBusca = new List<List<string>>();
            lista = ClienteUnit.ListaFichario();

            //Exibindo a lista de clientes
            foreach (var item in lista)
            {
                Cliente.Unit cliente = Cliente.DesSerializeClassUnit(item);
                listaBusca.Add(new List<string> { cliente.Id, cliente.Nome });
            }

            Form_Busca busca = new Form_Busca(listaBusca);
            busca.ShowDialog();
            if (busca.DialogResult == DialogResult.OK)
            {
                ClienteUnit = ClienteUnit.BuscarFichario(busca.idSelected);
                PreencherForm(ClienteUnit);
            }
        }

    }
}
