using System;
using Repositories;
using Controllers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ClienteModels
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DtNasc { get; set; }
        public string Cpf { get; set; }
        public int DiasDevol { get; set; }

        public List<LocacaoModels > Locacoes { get; set; }

        public ClienteModels () {

        }
        public ClienteModels (string nome, DateTime dtNasc, string cpf, int dias)
        {
            Nome = nome;
            DtNasc = dtNasc;
            Cpf = cpf;
            DiasDevol = dias;

            Context db = new Context();
            db.Clientes.Add(this);
            db.SaveChanges();
        }

       
        public void InserirLocacao(LocacaoModels locacao) 
        {
            Locacoes.Add(locacao);
        }

        public static ClienteModels GetCliente(int idCliente)
        {
            return ClienteRepositories.Clientes().Find(cliente => cliente.Id == idCliente);
        }

        public static List<ClienteModels> GetClientes()
        {
            return Repositories.ClienteRepositories.clientes;
        }

        public string ToString(bool simple = false)
        {
            if (simple)
            {
                string retorno = $"Id: {Id} - Nome: {Nome}\n" +
                    "   Locações: \n";
                if (Locacoes.Count > 0)
                {
                    Locacoes.ForEach(
                        locacao => retorno += 
                        $"    Id: {locacao.Id} - " +
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
    }
}



