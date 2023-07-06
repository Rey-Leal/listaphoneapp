using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace ListaPhoneApp
{
    public partial class CadastraProdutos : PhoneApplicationPage
    {
        public CadastraProdutos()
        {
            InitializeComponent();
            EncheItensCadastrados();
        }

        private void EncheItensCadastrados()
        {
            try
            {
                lstCadastrados.Items.Clear();

                List<ProdutoBO> listaDeProdutos = new List<ProdutoBO>();
                listaDeProdutos = Controle.LeTodosProdutos();

                if (listaDeProdutos != null)
                {
                    for (int i = 0; i < listaDeProdutos.Count; i++)
                    {
                        this.lstCadastrados.Items.Add(listaDeProdutos[i].Descricao);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu o seguinte erro: \n " + ex.Message.ToString(), Controle.NomeDaAplicacao, MessageBoxButton.OK);
            }
        }

        private void btnInserir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtProduto.Text != string.Empty)
                {
                    Controle.GravaProduto(txtProduto.Text);
                    this.txtProduto.Text = string.Empty;
                    EncheItensCadastrados();
                }
                else
                {
                    MessageBox.Show("Informe a mercadoria!", Controle.NomeDaAplicacao, MessageBoxButton.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu o seguinte erro: \n " + ex.Message.ToString(), Controle.NomeDaAplicacao, MessageBoxButton.OK);
            }
        }

        //Remove na unha, necessario descobrir como remover apenas uma linha do Storage
        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            if ((this.lstCadastrados.Items.Count <= 0) || (this.lstCadastrados.SelectedIndex == -1))
            {
                MessageBox.Show("Selecione um item na lista de cadastrados!", Controle.NomeDaAplicacao, MessageBoxButton.OK);
            }
            else
            {
                this.lstCadastrados.Items.RemoveAt(this.lstCadastrados.SelectedIndex);

                List<String> produtosAtuais = new List<string>();

                for (int i = 0; i < lstCadastrados.Items.Count; i++)
                {
                    produtosAtuais.Add(lstCadastrados.Items[i].ToString());
                }

                Controle.ApagarTodosProdutos();

                for (int i = 0; i < produtosAtuais.Count; i++)
                {
                    Controle.GravaProduto(produtosAtuais[i]);
                }

                EncheItensCadastrados();
            }
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnApagarTodosProdutos_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente apagar todos produtos?", Controle.NomeDaAplicacao, MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                try
                {
                    Controle.ApagarTodosProdutos();
                    EncheItensCadastrados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Aconteceu o seguinte erro: \n " + ex.Message.ToString(), Controle.NomeDaAplicacao, MessageBoxButton.OK);
                }
            }
        }
    }
}