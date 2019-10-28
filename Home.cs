using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_ProjetoLC;
using BLL_ProjetoLC;

namespace UI_ProjetoLC
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
            TimeSpan tarde = new TimeSpan(12, 0, 0);
            TimeSpan noite = new TimeSpan(18, 0, 0);
            TimeSpan HoraAtual = DateTime.Now.TimeOfDay;
            if (HoraAtual < tarde)
            {
                lblSaudacaoHome.Text = "Bom Dia!";
            }
            else if (HoraAtual < noite)
            {
                lblSaudacaoHome.Text = "Boa Tarde!";
            }
            else
            {
                lblSaudacaoHome.Text = " Boa noite!";
            }

            string Cargo = "Funcionario";

            if (Cargo == "Funcionario")
            {
                this.tcControlePag.TabPages.Remove(tabPage3);
                this.tcControlePag.TabPages.Remove(tabPage4);
                this.tcControlePag.TabPages.Remove(tabPage5);
                this.tcControlePag.TabPages.Remove(tabPage6);
                this.tcControlePag.TabPages.Remove(tabPage7);
            }
        }
        public HOME (PessoaDTO pessoa)
        {
            InitializeComponent();
            TimeSpan tarde = new TimeSpan(12, 0, 0);
            TimeSpan noite = new TimeSpan(18, 0, 0);
            TimeSpan HoraAtual = DateTime.Now.TimeOfDay;
            if (HoraAtual < tarde)
            {
                lblSaudacaoHome.Text = "Bom dia!";
            }
            else if (HoraAtual < noite)
            {
                lblSaudacaoHome.Text = "Boa Tarde!";
            }
            else
            {
                lblSaudacaoHome.Text = " Boa noite!";
            }

            lblNomeHome.Text = pessoa.Nome;

           /* if (pessoa.Cargo == "Funcionario")
            {
                this.tcControlePag.TabPages.Remove(tabPage3);
                this.tcControlePag.TabPages.Remove(tabPage4);
                this.tcControlePag.TabPages.Remove(tabPage5);
                this.tcControlePag.TabPages.Remove(tabPage6);
                this.tcControlePag.TabPages.Remove(tabPage7);
            }*/
        }


        private void HOME_Load(object sender, EventArgs e)
        {

        }
    

        private void BtnCadasdProd_Click(object sender, EventArgs e)
        {
            //ve se os campos estao vazios, validar todas as informaçoes
            try
            {
                //metodos com sob

                ProdutoDTO obj = new ProdutoDTO();
                //armazenando os valores das caixas na propriedades

                //vai criar uma classe, e validar as informaçoes atráves delas, 

                //provalvelmente vai ser em BLL

                obj.CodBarra = txtCodProd.Text;
                obj.LoteProd = txtLoteProd.Text;
                obj.ValProd = mtbValProd.Text;
                obj.NomeProd = txtProd.Text;
                obj.DescProd = txtDescProd.Text;
                obj.QtdProd = txtQtdProdCad.Text;
                obj.PrecoProd = txtPrecProdCasd.Text;
                obj.MedProd = cbUnProd.Text;
                string mensagem = ProdutoBLL.CadProduto(obj);
                MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCodProd.Clear(); ;
                txtLoteProd.Clear();
                mtbValProd.Clear();
                txtProd.Clear();
                txtQtdProdCad.Clear();
                txtPrecProdCasd.Clear();
                cbUnProd.SelectedIndex = -1;
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnLimProd_Click(object sender, EventArgs e)
        {
            txtCodProd.Clear(); ;
            txtLoteProd.Clear();
            mtbValProd.Clear();
            txtProd.Clear();
            txtQtdProdCad.Clear();
            txtPrecProdCasd.Clear();
            cbUnProd.SelectedIndex = -1;
        }

        private void BtnCadFunc_Click(object sender, EventArgs e)
        {

            //ve se os campos estao vazios, validar todas as informaçoes
            try
            {
                //metodos com sob

                PessoaDTO obj = new PessoaDTO();
                //armazenando os valores das caixas na propriedades

                //vai criar uma classe, e validar as informaçoes atráves delas, provalvelmente vai ser em BLL

                obj.Nome = txtNomeFunc.Text;
                obj.DataNascimento = mtbNascFunc.Text;
                obj.CPF = mtbCPFFunc.Text;
                obj.TelCelular = mtbCelFunc.Text;
                obj.RG = txtRGFunc.Text;
                obj.Cargo = txtCargoFunc.Text;
                obj.TelFixo = mtbFixoFunc.Text;
                obj.Estado = cbUFFunc.Text;
                obj.Endereco = txtEndFunc.Text;
                obj.Numero = txtNumFunc.Text;
                obj.Bairro = txtBairFunc.Text;
                obj.Cidade = txtCidFunc.Text;
                obj.CEP = mtbCEPFunc.Text;

                if (rbFFunc.Checked == true)
                {
                    obj.Sexo = rbFFunc.Text;
                }
                if (rbMFunc.Checked == true)
                {
                    obj.Sexo = rbMFunc.Text;
                }
                if (rbOFunc.Checked == true)
                {
                    obj.Sexo = rbOFunc.Text;
                }
                if (rbAtFunc.Checked == true)
                {
                    obj.StatusPes = rbAtFunc.Text;
                }
                if (rbInaFunc.Checked == true)
                {
                    obj.StatusPes = rbInaFunc.Text;
                }

                string mensagem = FuncionarioBLL.CadFuncionario(obj);
                MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtNomeFunc.Clear();
                mtbNascFunc.Clear();
                mtbCPFFunc.Clear();
                mtbCelFunc.Clear();
                txtRGFunc.Clear();
                txtCargoFunc.Clear();
                mtbFixoFunc.Clear();
                cbUFFunc.SelectedIndex = -1;
                txtEndFunc.Clear();
                txtNumFunc.Clear();
                txtBairFunc.Clear();
                txtCidFunc.Clear();
                mtbCEPFunc.Clear();
                rbFFunc.Checked = false;
                rbMFunc.Checked = false;
                rbOFunc.Checked = false;
                rbAtFunc.Checked = false;
                rbInaFunc.Checked = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void BtnLimFunc_Click(object sender, EventArgs e)
        {
            txtNomeFunc.Clear();
            mtbNascFunc.Clear();
            mtbCPFFunc.Clear();
            mtbCelFunc.Clear();
            txtRGFunc.Clear();
            txtCargoFunc.Clear();
            mtbFixoFunc.Clear();
            cbUFFunc.SelectedIndex = -1;
            txtEndFunc.Clear();
            txtNumFunc.Clear();
            txtBairFunc.Clear();
            txtCidFunc.Clear();
            mtbCEPFunc.Clear();
            rbFFunc.Checked = false;
            rbMFunc.Checked = false;
            rbOFunc.Checked = false;
            rbAtFunc.Checked = false;
            rbInaFunc.Checked = false;

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void mtbValProd_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BtnAlterProd_Click(object sender, EventArgs e)
        {
            AlterarProduto tela = new AlterarProduto();

            tela.ShowDialog();
        }
    }
}



