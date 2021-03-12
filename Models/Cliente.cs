using System;
using Repositories;
using Controllers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ClienteModels
    {
        private string v1;
        private DateTime dateTime;
        private string v2;
        private int v3;
        [Key]
        public int ClienteId { get; set; }
        [Required]
    
        public string Nome { get; set; }
        public DateTime DtNasc { get; set; }
        public string Cpf { get; set; }
        public int DiasDevol { get; set; }

        public List<LocacaoModels > Locacoes { get; set; }

        public ClienteModels (int IdCliente, string nome, DateTime dtNasc, string cpf, int dias)
        {
            IdCliente = ClienteRepositories.GetId();
            Nome = nome;
            DtNasc = dtNasc;
            Cpf = cpf;
            DiasDevol = dias;

            ClienteRepositories.clientes.Add(this);
        }

        public ClienteModels(string v1, DateTime dateTime, string v2, int v3)
        {
            this.v1 = v1;
            this.dateTime = dateTime;
            this.v2 = v2;
            this.v3 = v3;
        }

        public void InserirLocacao(LocacaoModels locacao) 
        {
            Locacoes.Add(locacao);
        }

        public static ClienteModels GetCliente(int idCliente)
        {
            return ClienteRepositories.Clientes().Find(cliente => cliente.ClienteId == idCliente);
        }

        public static List<ClienteModels> GetClientes()
        {
            return Repositories.ClienteRepositories.clientes;
        }

        public string ToString(bool simple = false)
        {
            if (simple)
            {
                string retorno = $"Id: {ClienteId} - Nome: {Nome}\n" +
                    "   Locações: \n";
                if (Locacoes.Count > 0)
                {
                    Locacoes.ForEach(
                        locacao => retorno += 
                        $"    Id: {locacao.LocacaoId} - " +
                        $"Data: {locacao.DtLocacao} - " +
                        $"Data de Devolução: {LocacaoController.GetDataDevolucao(locacao)}\n"
                    );
                }
                else
                {
                    retorno += "    Não há locações";
                }
                return retorno;
            }
            string dtNasc = this.DtNasc.ToString("dd/MM/yyyy");

            return $"Nome: {Nome}\n" +
                $"Data de Nasciment: {dtNasc}\n" +
                $"Qtd de Carros: {ClienteController.GetQtdCarro(this)}";
        }


        public static void Importar()
        {
            ClienteModels cliente;
            LocacaoModels locacao;

            cliente = new ClienteModels(
                "Pedro Pereira",
                new DateTime(1953, 5, 4),
                "987.546.254.11",
                6
            );
            locacao = new LocacaoModels(
                cliente,
                DateTime.Now.AddDays(-5)
            );
            locacao.InserirCarro(CarroModels.GetCarro(1));
            locacao.InserirCarro(CarroModels.GetCarro(2));

            cliente = new ClienteModels(
                "Eduarda Santos ",
                new DateTime(1988, 1, 2),
                "889.578.542.21",
                8
            );
            locacao = new LocacaoModels(
                cliente,
                DateTime.Now.AddDays(-8)
            );
            locacao.InserirCarro(CarroModels.GetCarro(1));
            locacao.InserirCarro(CarroModels.GetCarro(6));

            cliente = new ClienteModels(
                " Joana Aparecida",
                new DateTime(1985, 12, 7),
                "897.412.547.88",
                2
            );
            locacao = new LocacaoModels(
                cliente,
                DateTime.Now.AddDays(-10)
            );
            locacao.InserirCarro(CarroModels.GetCarro(1));
            locacao.InserirCarro(CarroModels.GetCarro(3));

            cliente = new ClienteModels(
                "Carol Araújo",
                new DateTime(1985, 07, 25),
                "698.458.741.20",
                5
            );
            locacao = new LocacaoModels(
                cliente,
                DateTime.Now.AddDays(-20)
            );
            locacao.InserirCarro(CarroModels.GetCarro(1));
            locacao.InserirCarro(CarroModels.GetCarro(5));
            locacao.InserirCarro(CarroModels.GetCarro(4));

            locacao = new LocacaoModels(
                cliente,
                DateTime.Now
            );
            locacao.InserirCarro(CarroModels.GetCarro(6));
            locacao.InserirCarro(CarroModels.GetCarro(2));
            locacao.InserirCarro(CarroModels.GetCarro(9));

            cliente = new ClienteModels(
                "Diana medeiros ",
                new DateTime(1856, 05, 4),
                "568.487.956.25",
                15
            );
            locacao = new LocacaoModels(
                cliente,
                DateTime.Now
            );
            locacao.InserirCarro(CarroModels.GetCarro(1));
            locacao.InserirCarro(CarroModels.GetCarro(5));
            locacao.InserirCarro(CarroModels.GetCarro(4));
        }

    }
}