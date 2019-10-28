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
    public class FuncionarioDAL
    {
        public static string CadFuncionario(PessoaDTO obj)
        {
            try
            {
                string script = "Insert Into Pessoa(nome,cargo, dtNascimento,sexo,telFixo,telCelular,statusPes,RG,CPF,email,username,senha) " +
                       "Values (@nome,@cargo, @dtNascimento,@sexo,@telFixo,@telCelular,@statusPes,@RG,@CPF,@email,@username,@senha)";
                SqlCommand cm = new SqlCommand(script, Conexao.Conectar());
                cm.Parameters.AddWithValue("@nome", obj.Nome);
                cm.Parameters.AddWithValue("@cargo", obj.Cargo);
                cm.Parameters.AddWithValue("@dtNascimento", obj.DataNascimento);
                cm.Parameters.AddWithValue("@sexo", obj.Sexo);
                cm.Parameters.AddWithValue("@telFixo", obj.TelFixo);
                cm.Parameters.AddWithValue("@telCelular", obj.TelCelular);
                cm.Parameters.AddWithValue("@statusPes", obj.StatusPes);
                cm.Parameters.AddWithValue("@RG", obj.RG );
                cm.Parameters.AddWithValue("@CPF", obj.CPF);
                cm.Parameters.AddWithValue("@email", obj.Email);
                cm.Parameters.AddWithValue("@userName", obj.UserName);
                cm.Parameters.AddWithValue("@senha", obj.Senha);
                cm.ExecuteNonQuery();
                return ("Funcionario cadastrado com sucesso");
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

    }
}
