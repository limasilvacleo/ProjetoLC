using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_ProjetoLC;
using DAL_ProjetoLC;


namespace BLL_ProjetoLC
{
    public class FuncionarioBLL
    {
        public static string CadFuncionario(PessoaDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Nome))
            {
                throw new Exception("Campo, nome vazio");
            }
            if (string.IsNullOrWhiteSpace(obj.CPF))
            {
                throw new Exception("Campo, cpf vazio");
            }
            if (obj.CPF .Length != 11)
            {
                throw new Exception("Campo, CPF precisa conter 11 digito");
            }
            obj.Email = "";
            obj.UserName = "";
            obj.Senha = "";
            return FuncionarioDAL.CadFuncionario(obj);
        }

    }
}
