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
        [Key]
        public int CarroId { get; set; }
        [Required]
        public string Modelo { get; set; }
        public string Datafabricacao { get; set; }
        public double ValorLocacaoCarro { get; set; }
        public int Estoque { get; set; }
        public int CarroLocado { get; set; }

        //public List<LocacaoModels> locacaos = new List<LocacaoModels>();

        // Construtor
        public CarroModels(int idCarro, string Modelo, string datafabricacao, double valorLocacaoCarro, int estoque)
        {
            CarroId = CarroRepositories.GetId();
            this.Modelo = Modelo;
            Datafabricacao = datafabricacao;
            ValorLocacaoCarro = valorLocacaoCarro;
            Estoque = estoque;
            CarroLocado = 0;

            CarroRepositories.carros.Add(this);
        }

        // Retorno do Carro pelo ID
        public static CarroModels GetCarro(int idCarro)
        {
            return CarroRepositories.Carro().Find(Carro => Carro.CarroId == idCarro);
        }

        public static List<CarroModels> GetCarro()
        {
            return Repositories.CarroRepositories.carros;
        }
       public CarroModels (){

       }
    }
}