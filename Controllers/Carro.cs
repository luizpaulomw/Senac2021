using Models;
using System;
using System.Collections.Generic;
using View;

namespace Controllers
{
    public class CarroController
    {
        public static void addCarro(string Modelo, string dataLanc, double valorLoc, int estoque)
        {
            new CarroModels(Modelo, dataLanc, valorLoc, estoque);
        }

        public string GetCarro(CarroModels carro)
        {
            string carroValue = carro.ToString();

            return carroValue;
        }

        public static List<CarroModels> GetCarro()
        {
            return CarroModels.GetCarro();
        }

        internal static void InserirCarro(string nome, string data_Lancamento, double valor)
        {
            throw new NotImplementedException();
        }

        internal static CarroView GetCarro(int idCarro)
        {
            throw new NotImplementedException();
        }
    }
}