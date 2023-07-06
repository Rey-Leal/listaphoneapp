using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using System.Collections.Generic;

namespace ListaPhoneApp
{
    public class Controle
    {
        public const String NomeDaAplicacao = "Lista de Compras";

        public static void GravaProduto(String produto)
        {
            try
            {
                ProdutoBO produtoBO = new ProdutoBO(produto);
                ProdutoDAO.GravaProduto(produtoBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<ProdutoBO> LeTodosProdutos()
        {
            try
            {
                return ProdutoDAO.LeTodosProdutos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ApagarTodosProdutos()
        {
            try
            {
                ProdutoDAO.ApagaTodosProdutos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
