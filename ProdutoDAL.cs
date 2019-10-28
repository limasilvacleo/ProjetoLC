using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_ProjetoLC;
using System.Data;
using System.Data.SqlClient;


namespace DAL_ProjetoLC
{
    public class ProdutoDAL
    {
        public static string CadProduto(ProdutoDTO obj)
        {
            try
            {
                string script = "Insert into Produto(codBarra,loteProd,valProd,nomeProd, descProd,qtdProd,precoProd,medProd) " +
                       "Values(@codBarra,@loteProd,@valProd,@nomeProd, @descProd,@qtdProd,@precoProd,@medProd)";
                SqlCommand cm = new SqlCommand(script, Conexao.Conectar());
                cm.Parameters.AddWithValue("@codBarra", obj.CodBarra);
                cm.Parameters.AddWithValue("@loteProd", obj.LoteProd);
                cm.Parameters.AddWithValue("@valProd", obj.ValProd);
                cm.Parameters.AddWithValue("@nomeProd", obj.NomeProd);
                cm.Parameters.AddWithValue("@descProd", obj.DescProd);
                cm.Parameters.AddWithValue("@qtdProd", obj.QtdProd);
                cm.Parameters.AddWithValue("@precoProd", obj.PrecoProd);
                cm.Parameters.AddWithValue("@medProd", obj.MedProd);
                cm.ExecuteNonQuery();
                return ("Produto cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (Conexao.Conectar().State != ConnectionState.Closed)
                {
                    Conexao.Conectar().Close();
                }
            }

        }
        public static ProdutoDTO BuscarProd(string cod)
        {
            string script = ("Select * From Produto where@codBarra,@loteProd,@valProd,@nomeProd, @descProd,@qtdProd,@precoProd,@medProd");
            SqlCommand cm = new SqlCommand (script, Conexao.Conectar());
            cm.Parameters.AddWithValue("@codBarra", cod);
            SqlDataReader dados = cm.ExecuteReader();
            while(dados.Read()){
                if (dados.HasRows)
                {

                }

            }
        }
    } 
}