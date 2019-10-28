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


namespace UI_ProjetoLC//UI - User Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtSenhaLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAcessarLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoginDTO obj = new LoginDTO();
                PessoaDTO pessoa = new PessoaDTO();

                obj.Usuario = txtUserLogin.Text;
                obj.Senha = txtSenhaLogin.Text;

                pessoa = LoginBLL.vldLogin(obj);

                if (pessoa.Nome != "" && pessoa.StatusPes.ToLower() != "False")
                {
                    this.Hide();
                    HOME telaInicio = new HOME (pessoa);
                    telaInicio.ShowDialog();
                    this.Close();
                }
                else
                {
                    throw new Exception("Usuário ou senha inválidos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

