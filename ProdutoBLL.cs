using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO_ProjetoLC;
using DAL_ProjetoLC;
using System.Data;


namespace BLL_ProjetoLC
{
    public class ProdutoBLL
    {

        public static string CadProduto(ProdutoDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.CodBarra))
            {
                throw new Exception("Campo, código de barra vazio");
            }
            if (obj.CodBarra.Length != 13)
            {
                throw new Exception("Campo, código de barra precisa conter 13 digito");
            }
            try
            {
                Int64.Parse(obj.CodBarra);
            }
            catch
            {
                throw new Exception("Código de Barra deve ser somente número");
            }
            if (string.IsNullOrWhiteSpace(obj.LoteProd))
            {
                throw new Exception("Campo, lote está vazio");
            }
           /* if (string.IsNullOrWhiteSpace(obj.ValProd))
            {
                throw new Exception("Campo, validade está vazio");
            }*/
            if (string.IsNullOrWhiteSpace(obj.NomeProd))
            {
                throw new Exception("Campo, produto está vazio");
            }
            if (string.IsNullOrWhiteSpace(obj.DescProd))
            {
                throw new Exception("Campo, descrição está vazio");
            }
            if (string.IsNullOrWhiteSpace(obj.QtdProd))
            {
                throw new Exception("Campo,quantidade está vazio");
            }
            try
            {
                Int64.Parse(obj.QtdProd);
            }
            catch
            {
                throw new Exception("Quantidade deve ser somente número");
            }
            if (string.IsNullOrWhiteSpace(obj.MedProd))
            {
                throw new Exception("Campo, Unidade está vazio");
            }

            if (string.IsNullOrWhiteSpace(obj.PrecoProd))
            {
                throw new Exception("Campo, preço está vazio");
            }
            return ProdutoDAL.CadProduto(obj);
        }
        public static ProdutoDTO BuscarProduto(string codbarra)
        {
            if(string .IsNullOrWhiteSpace(codbarra ))
            {
                throw new Exception ("Campo de Busca Obrigatorio");
            }
            /* validar 12 digitos*/
            /* vlidar só numero*/
            
            if (string.IsNullOrWhiteSpace(codbarra))
            {
                throw new Exception("Campo, código de barra vazio");
            }
            if (codbarra.Length != 13)
            {
                throw new Exception("Campo, código de barra precisa conter 13 digito");
            }
            try
            {
                Int64.Parse(codbarra);
            }
            catch
            {
                throw new Exception("Código de Barra deve ser somente número");
            }
        
            return ProdutoDAL.BuscarProd(codbarra);
        }
        

    }
}
 

