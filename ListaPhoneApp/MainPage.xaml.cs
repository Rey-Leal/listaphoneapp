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

using System.IO;
using System.IO.IsolatedStorage;

namespace ListaPhoneApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            EncheItensCadastrados();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            //Load
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
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

        private void btnPendente_Click(object sender, RoutedEventArgs e)
        {

            int i;

            if ((this.lstCadastrados.Items.Count <= 0) || (this.lstCadastrados.SelectedIndex == -1))
            {
                MessageBox.Show("Selecione um item na lista de cadastrados!", Controle.NomeDaAplicacao, MessageBoxButton.OK);
            }
            else
            {
                if (int.TryParse(this.txtQuantidade.Text, out i))
                {
                    this.lstPendente.Items.Add(txtQuantidade.Text + " - " + this.lstCadastrados.SelectedValue.ToString());
                    txtQuantidade.Text = "0";
                }
                else
                {
                    MessageBox.Show("A quantidade deve ter valor númerico!", Controle.NomeDaAplicacao, MessageBoxButton.OK);
                }
            }
        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            if ((this.lstPendente.Items.Count <= 0) || (this.lstPendente.SelectedIndex == -1))
            {
                MessageBox.Show("Selecione um item na lista de pendentes!", Controle.NomeDaAplicacao, MessageBoxButton.OK);
            }
            else
            {
                this.lstPendente.Items.RemoveAt(this.lstPendente.SelectedIndex);
            }
        }

        private void btnComprar_Click(object sender, RoutedEventArgs e)
        {
            if ((this.lstPendente.Items.Count <= 0) || (this.lstPendente.SelectedIndex == -1))
                MessageBox.Show("Selecione um item pendente!", Controle.NomeDaAplicacao, MessageBoxButton.OK);
            else
            {
                this.lstComprado.Items.Add(this.lstPendente.SelectedValue.ToString());
                this.lstPendente.Items.RemoveAt(this.lstPendente.SelectedIndex);
            }
        }

        private void btnDesfazer_Click(object sender, RoutedEventArgs e)
        {
            if ((this.lstComprado.Items.Count <= 0) || (this.lstComprado.SelectedIndex == -1))
                MessageBox.Show("Selecione um item comprado!", Controle.NomeDaAplicacao, MessageBoxButton.OK);
            else
            {
                this.lstPendente.Items.Add(this.lstComprado.SelectedValue.ToString());
                this.lstComprado.Items.RemoveAt(this.lstComprado.SelectedIndex);
            }
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do aplicativo?", Controle.NomeDaAplicacao, MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                base.OnBackKeyPress(e);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnNovoProduto_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CadastraProdutos.xaml", UriKind.Relative));
        }
    }
}