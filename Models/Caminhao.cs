using System;
using Controllers;
using Repositories;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class CaminhaoModels
    {
        // Atributos
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Datafabricação { get; set; }
        public double ValorLocacaoCaminhao { get; set; }
        public int Estoque { get; set; }
        public int CaminhaoLocado { get; set; }

        public List<LocacaoModels> locacaos = new List<LocacaoModels>();

        // Construtor
        public CaminhaoModels () { 

        }
        public CaminhaoModels(string Modelo, string datafabricação, double valorLocacaoCaminhao, int estoque)
        {
           
            this.Modelo = Modelo;
            Datafabricação = datafabricação;
            ValorLocacaoCaminhao = valorLocacaoCaminhao;
            Estoque = estoque;
            CaminhaoLocado = 0;
            Context db = new Context();
            db.Caminhao.Add(this);
            db.SaveChanges();
        }

        // Retorno do Caminhao pelo ID
        public static CaminhaoModels GetCaminhao(int idCaminhao)
        {
            return CaminhaoRepositories.Caminhao().Find(Caminhao => Caminhao.Id == idCaminhao);
        }

        public static List<CaminhaoModels> GetCaminhao()
        {
            return Repositories.CaminhaoRepositories.caminhoes;
        }

    }
}