using System;
using Controllers;
using Repositories;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class CarroModels
    {
        // Atributos
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Datafabricação { get; set; }
        public double ValorLocacaoCarro { get; set; }
        public int Estoque { get; set; }
        public int CarroLocado { get; set; }

        public List<LocacaoModels> locacaos = new List<LocacaoModels>();

        // Construtor
        public CarroModels () { 

        }
        public CarroModels(string Modelo, string datafabricação, double valorLocacaoCarro, int estoque)
        {
            //CarroId = CarroRepositories.GetId();
            this.Modelo = Modelo;
            Datafabricação = datafabricação;
            ValorLocacaoCarro = valorLocacaoCarro;
            Estoque = estoque;
            CarroLocado = 0;
            Context db = new Context();
            db.Carros.Add(this);
            db.SaveChanges();
        }

        // Retorno do Carro pelo ID
        public static CarroModels GetCarro(int idCarro)
        {
            return CarroRepositories.Carro().Find(Carro => Carro.Id == idCarro);
        }

        public static List<CarroModels> GetCarro()
        {
            return Repositories.CarroRepositories.carros;
        }

    }
}