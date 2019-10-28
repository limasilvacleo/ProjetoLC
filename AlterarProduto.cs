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
    public partial class AlterarProduto : Form
    {
        public AlterarProduto()
        {
            InitializeComponent();
        }

        private void PbBuscaAlterProd_Click(object sender, EventArgs e)
        {
            try
            {
                string codBarra, mensagem;
                codBarra = TxtCodAlterProd.Text;
                ProdutoDTO  obj  =new ProdutoDTO();
                 obj= ProdutoBLL.BuscarProduto(codBarra);
            }
            catch
            {

            }

        }
    }
        
}
