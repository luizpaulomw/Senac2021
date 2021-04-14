using System;
using Models;
using System.Collections.Generic;
using View;

namespace Controllers
{
    public class LocacaoController
    {
        public static LocacaoModels InserirLocacao(ClienteModels cliente)
        {
            return new LocacaoModels (cliente, DateTime.Now);
        }

        public static void InserirCarro(  LocacaoModels locacao, CarroModels carro)
        {
            locacao.InserirCarro(carro);
        }

        public static double GetValorTotal(List<CarroModels> carros)
        {
            double ValorTotal = 0;

            foreach (CarroModels carro in carros)
            {
                ValorTotal += carro.ValorLocacaoCarro;
            }

            return Math.Round(ValorTotal, 2);
        }

        public static double GetQtdCarro(LocacaoModels locacao)
        {
            return 0;//locacao.carros.Count;
        }

        public static string GetDataDevolucao(DateTime Data)
        {
           
            return Data.ToString().Substring(0, 10);
        }

        public static List<LocacaoModels> GetLocacao()
        {
            return LocacaoModels.GetLocacao();
        }

        internal static LocacaoView InserirLocacao(ClienteView cliente)
        {
            throw new NotImplementedException();
        }

        public static LocacaoModels GetLocacao(int idLocacao)
        {
            return LocacaoModels.GetLocacao(idLocacao);
        }

        internal static object GetDataDevolucao(LocacaoModels locacao)
        {
            throw new NotImplementedException();
        }

        internal static void Inserircarro(LocacaoView locacao)
        {
            throw new NotImplementedException();
        }

        public static LocacaoModels addLocacao(int idLocacao, ClienteModels cliente)
        {
            return new LocacaoModels(idLocacao, cliente);
        }
    }
}