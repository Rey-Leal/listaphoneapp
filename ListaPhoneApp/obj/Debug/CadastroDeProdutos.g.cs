﻿#pragma checksum "d:\reinaldo\documents\visual studio 2010\Projects\ListaPhoneApp\ListaPhoneApp\CadastroDeProdutos.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "13511DF01349234E6F8E9DEF49B20B3F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace ListaPhoneApp {
    
    
    public partial class CadastroDeProdutos : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.TextBox txtProduto;
        
        internal System.Windows.Controls.Button btnInserir;
        
        internal System.Windows.Controls.Button btnRemover;
        
        internal System.Windows.Controls.TextBlock textBlock4;
        
        internal System.Windows.Controls.ListBox lstCadastrados;
        
        internal System.Windows.Controls.Button btnVoltar;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/ListaPhoneApp;component/CadastroDeProdutos.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.txtProduto = ((System.Windows.Controls.TextBox)(this.FindName("txtProduto")));
            this.btnInserir = ((System.Windows.Controls.Button)(this.FindName("btnInserir")));
            this.btnRemover = ((System.Windows.Controls.Button)(this.FindName("btnRemover")));
            this.textBlock4 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock4")));
            this.lstCadastrados = ((System.Windows.Controls.ListBox)(this.FindName("lstCadastrados")));
            this.btnVoltar = ((System.Windows.Controls.Button)(this.FindName("btnVoltar")));
        }
    }
}
