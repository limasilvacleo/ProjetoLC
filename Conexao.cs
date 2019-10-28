using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//importando a biblioteca de classe do banco de dados


namespace DAL_ProjetoLC
{
    public class Conexao
    {
        //vai ser usada para conectar todos acessados pelo DAL
        public static SqlConnection Conectar()

        {
           /* try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
                Initial Catalog=ProjetoLC;Integrated Security=True;Connect Timeout=30;Encrypt=False;
                TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //pegar o caminho na propriedade  do Banco
                conn.Open();
                return conn;
            }*/
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=ProjetoLC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
   
                //pegar o caminho na propriedade  do Banco
                conn.Open();
                return conn;
            }
            catch(Exception ex)
            {
                throw new Exception("Não foi possivel conectar. Tente novamente!"+ex.Message);
            }
        }

    }
}
