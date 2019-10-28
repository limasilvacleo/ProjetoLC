using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_ProjetoLC;
using DTO_ProjetoLC;


namespace BLL_ProjetoLC
{
    public class LoginBLL
    {
        public static PessoaDTO vldLogin(LoginDTO obj)
        {

            if (string.IsNullOrWhiteSpace(obj.Usuario))
            {
                //validando se o campo esta vazio, e ira aparecer o return

                throw new Exception("Informe seu nome de Usuário ou E-mail");
            }

            if (string.IsNullOrWhiteSpace(obj.Senha))
            {
                throw new Exception("Informe sua Senha");
            }

            //return "Sucesso";
            return LoginDAL.vldLogin(obj);

        }

    }
}
