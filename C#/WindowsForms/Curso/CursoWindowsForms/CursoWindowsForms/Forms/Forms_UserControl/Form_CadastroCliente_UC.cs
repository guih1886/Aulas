using CursoWindowsFormsBiblioteca;
using CursoWindowsFormsBiblioteca.Classes;
using CursoWindowsFormsBiblioteca.Databases;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Windows.Forms;

namespace CursoWindowsForms.Forms.Forms_UserControl
{
    public partial class Form_CadastroCliente_UC : UserControl
    {
        public Form_CadastroCliente_UC()
        {
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
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit cliente = new Cliente.Unit();
                cliente = LeituraForm();
                cliente.ValidaClasse();
                cliente.ValidaComplemento();
                string clienteJson = Cliente.SerializeClassUnit(cliente);

                Fichario fichario = new Fichario("C:\\Fichario");
                if (fichario.status)
                {
                    fichario.Incluir(cliente.Id, clienteJson);
                    if (fichario.status)
                    {
                        MessageBox.Show(fichario.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparForm();
                    }
                    else
                    {
                        MessageBox.Show(fichario.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(fichario.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (ValidationException err)
            {
                MessageBox.Show(err.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Fichario fichario = new Fichario("C:\\Fichario");
                if (fichario.status)
                {
                    string clienteJson = fichario.Buscar(Txt_NumeroCliente.Text);
                    if (clienteJson != "")
                    {
                        Cliente.Unit cliente = Cliente.DesSerializeClassUnit(clienteJson);
                        PreencherForm(cliente);
                    }
                    else
                    {
                        MessageBox.Show(fichario.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show(fichario.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            Fichario fichario = new Fichario("C:\\Fichario");
            try
            {
                Cliente.Unit cliente = new Cliente.Unit();
                cliente = LeituraForm();
                cliente.ValidaClasse();
                cliente.ValidaComplemento();
                string clienteJson = Cliente.SerializeClassUnit(cliente);
                fichario.Atualizar(cliente.Id, clienteJson);
                MessageBox.Show(fichario.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparForm();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limparToolStripButton1_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void apagaToolStripButton2_Click(object sender, EventArgs e)
        {
            Fichario fichario = new Fichario("C:\\Fichario");
            var clienteId = Txt_NumeroCliente.Text;
            string clienteString = fichario.Buscar(clienteId);
            var cliente = Cliente.DesSerializeClassUnit(clienteString);
            PreencherForm(cliente);

            DialogResult result = MessageBox.Show($"Deseja realmente excluir o " +
                $"cadastro do cliente {clienteId}?", "ByteBank", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                fichario.Excluir(clienteId);
                MessageBox.Show(fichario.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparForm();
            }
        }

        private void PreencherForm(Cliente.Unit cliente)
        {
            Msk_CPF.Text = cliente.CPF;
            Txt_NomeCliente.Text = cliente.Nome;
            Txt_NomeMae.Text = cliente.NomeMae;
            Txt_NomePai.Text = cliente.NomePai;
            if (cliente.NaoTemPai == true) Ckb_TemPai.Checked = true;
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
            Cliente.Unit cliente = new Cliente.Unit();
            cliente.Id = Txt_NumeroCliente.Text;
            cliente.CPF = Msk_CPF.Text.Replace(",", "").Replace(".", "").Replace("-", "").Trim();
            cliente.Nome = Txt_NomeCliente.Text;
            cliente.NomeMae = Txt_NomeMae.Text;
            cliente.NomePai = Txt_NomePai.Text;
            cliente.NaoTemPai = false;
            if (Ckb_TemPai.Checked) cliente.NaoTemPai = true;
            if (Rdb_Masculino.Checked) cliente.Genero = 0;
            if (Rdb_Feminino.Checked) cliente.Genero = 1;
            if (Rdb_Indefinido.Checked) cliente.Genero = 2;
            cliente.Cep = Msk_CEP.Text.Replace("-", "");
            cliente.Logradouro = Txt_Logradouro.Text;
            cliente.Bairro = Txt_Bairro.Text;
            cliente.Cidade = Txt_Cidade.Text;
            cliente.Complemento = Txt_Complemento.Text;
            cliente.Estado = Cmb_Estados.SelectedIndex != -1 ? Cmb_Estados.Items[Cmb_Estados.SelectedIndex].ToString() : "";
            cliente.Telefone = Txt_Telefone.Text;
            cliente.Profissao = Txt_Profissao.Text;
            cliente.RendaFamiliar = (Information.IsNumeric(Txt_RendaFamiliar.Text) && double.Parse(Txt_RendaFamiliar.Text) > 0) ?
                cliente.RendaFamiliar = double.Parse(Txt_RendaFamiliar.Text) :
                cliente.RendaFamiliar = 0;
            return cliente;
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

    }
}
