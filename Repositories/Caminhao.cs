using System;
using System.Collections.Generic;
using Models;

namespace Repositories {
    public static class CaminhaoRepositories {
        public static readonly List<CaminhaoModels> caminhoes = new List<CaminhaoModels>();

        public static List<CaminhaoModels> caminhoesModels(){
            return caminhoes;
        }

        public static void AddCaminhao(CaminhaoModels caminhao){
            caminhoes.Add(caminhao);
        }

        public static int GetId(){
            return caminhoes.Count + 1;
        }

        public static List<CaminhaoModels> Caminhao()
        {
            return caminhoes;
        }

        internal static object Caminhoes()
        {
            throw new NotImplementedException();
        }
    }
}