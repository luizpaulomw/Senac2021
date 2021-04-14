using System;
using System.Collections.Generic;
using Controllers;
using Repositories;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class LocacaoModels
    {
        [Key]
        public int LocacaoId { get; set; }
        [Required]
        public ClienteModels Cliente { get; set; }
        public DateTime DtLocacao { get; set; }

       // public List<CarroModels> carros = new List<CarroModels>();

        public LocacaoModels(ClienteModels cliente, DateTime dtLocacao)
        {
            LocacaoId = LocacaoRepositories.GetId();
            Cliente = cliente;
            DtLocacao = dtLocacao;
            cliente.InserirLocacao(this);

            LocacaoRepositories.AdicionarLocacao(this);
        }

        public LocacaoModels(int idLocacao, ClienteModels cliente)
        {
            LocacaoId = idLocacao;
            Cliente = cliente;
        }

        public void AdicionarCarro(CarroModels carro)
        {
            //carros.Add(carro);
        }

        public void InserirCarro(CarroModels carro)
        {
           // carros.Add(carro);
        }


        public override string ToString()
        {
            string retorno = $"Cliente: {Cliente.Nome}" +
             //   $"Preço Total das Locações: {LocacaoController.GetValorTotal(carros)}" +
                $"Data da Locacao: {DtLocacao}" +
                $"Data de Devolucao: {LocacaoController.GetDataDevolucao(this)}" +
                "   Carro:\n";

            /*if (carros.Count > 0)
            {
                carros.ForEach(
                    carro => retorno += $"    Id: {carro.CarroId} - " +
                    $"Nome: {carro.Modelo}\n"
                );
            }
            else
            {
                retorno += "    Não há carros";
            }*/

            return retorno;
        }


        public static LocacaoModels GetLocacao(int LocacaoId)
        {
            return LocacaoRepositories.Locacoes().Find(locacao => locacao.LocacaoId == LocacaoId);
        }

        public static List<LocacaoModels> GetLocacao()
        {
            return LocacaoRepositories.Locacoes();
        }
        
        public LocacaoModels(){

        }

    }
}