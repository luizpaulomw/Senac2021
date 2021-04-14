using System;
using System.Collections.Generic;
using Models;

namespace Repositories {
    public static class CarroRepositories {
        public static readonly List<CarroModels> carros = new List<CarroModels>();

        public static List<CarroModels> carrosModels(){
            return carros;
        }

        public static void AddCarro(CarroModels carro){
            carros.Add(carro);
        }

        public static int GetId(){
            return carros.Count + 1;
        }

        public static List<CarroModels> Carro()
        {
            return carros;
        }

        internal static object Carros()
        {
            throw new NotImplementedException();
        }
    }
}