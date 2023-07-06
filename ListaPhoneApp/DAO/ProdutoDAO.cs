using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;

namespace ListaPhoneApp
{
    public class ProdutoDAO
    {
        public static void GravaProduto(ProdutoBO produtoBO)
        {
            IsolatedStorageFile isoFile;
            IsolatedStorageFileStream fileStream;
            StreamWriter streamWriter;

            try
            {
                isoFile = IsolatedStorageFile.GetUserStoreForApplication();

                if (!isoFile.DirectoryExists("Database"))
                {
                    isoFile.CreateDirectory("Database");
                    fileStream = new IsolatedStorageFileStream("Produtos.txt", System.IO.FileMode.Create, isoFile);
                }
                else
                {
                    fileStream = new IsolatedStorageFileStream("Produtos.txt", System.IO.FileMode.Append, isoFile);
                }

                streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(produtoBO.Descricao);
                streamWriter.Close();
                fileStream.Close();
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
                List<ProdutoBO> leTodosProdutos = new List<ProdutoBO>();

                IsolatedStorageFile isoFile = IsolatedStorageFile.GetUserStoreForApplication();

                if (isoFile.DirectoryExists("Database"))
                {
                    StreamReader streamReader = new StreamReader(new IsolatedStorageFileStream("Produtos.txt", FileMode.Open, isoFile));

                    while (!streamReader.EndOfStream)
                    {
                        ProdutoBO produtoBO = new ProdutoBO(streamReader.ReadLine());
                        leTodosProdutos.Add(produtoBO);
                        streamReader.Peek();
                    }
                    streamReader.Close();
                }

                return leTodosProdutos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ApagaTodosProdutos()
        {
            try
            {
                IsolatedStorageFile isoFile = IsolatedStorageFile.GetUserStoreForApplication();

                if (isoFile.DirectoryExists("Database"))
                {
                    isoFile.DeleteFile("Produtos.txt");
                    isoFile.DeleteDirectory("Database");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ApagaUmProduto()
        {
            try
            {
                //Implementar
                //Ainda não disponivel
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
