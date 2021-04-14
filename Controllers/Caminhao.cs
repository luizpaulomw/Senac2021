using Models;
using System;
using System.Collections.Generic;
using View;

namespace Controllers
{
    public class CaminhaoController
    {
        public static void addCaminhao(string Modelo, string dataLanc, double valorLoc, int estoque)
        {
            new CaminhaoModels(Modelo, dataLanc, valorLoc, estoque);
        }

        public string GetCaminhao(CaminhaoModels caminhao)
        {
            string CaminhaoValue = caminhao.ToString();

            return CaminhaoValue;
        }

        public static List<CaminhaoModels> GetCaminhao()
        {
            return CaminhaoModels.GetCaminhao();
        }

        internal static void InserirCaminhao(string nome, string data_Lancamento, double valor)
        {
            throw new NotImplementedException();
        }

        internal static CaminhaoView GetCaminhao(int idCaminhao)
        {
            throw new NotImplementedException();
        }
    }
}