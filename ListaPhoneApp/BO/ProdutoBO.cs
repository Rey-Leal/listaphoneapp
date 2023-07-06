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

namespace ListaPhoneApp
{
    public class ProdutoBO
    {
        //contrutores
        public ProdutoBO(String _descricao)
        {
            this.Descricao = _descricao;
        }

        public ProdutoBO()
        { 
        }

        //atributos
        private String _descricao;

        //propriedades
        public String Descricao
        {
            get { return _descricao; }
            set
            {
                if (value.Length > 25)
                {
                    _descricao =  value.Substring(0, 25).ToUpper();
                }
                else
                {
                    _descricao = value.ToUpper();
                }
            }
        }
    }
}
