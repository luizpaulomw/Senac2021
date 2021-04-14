using System;
using Models;
using System.Collections.Generic;

namespace Controllers
{
    public class ClienteController
    {
        public static void CadastraCliente(string nome, string DtNasc, string cpf, int DiasDevol)
        {
            DateTime Data_Nascimento;
            try
            {
                Data_Nascimento = Convert.ToDateTime(DtNasc);
            }
            catch
            {
                Console.WriteLine("Formato inválido de data, será utilizada a data atual pra cadastro");
                Data_Nascimento = DateTime.Now;
            }

            new ClienteModels ( nome, Data_Nascimento, cpf, DiasDevol);
        }

        internal static void InserirCliente(string nome, string sDtNasc, string cpf, int qtdDias)
        {
            throw new NotImplementedException();
        }

        public static int GetQtdCarro(ClienteModels cliente)
        {
            int qtdCarro = 0;

            cliente.Locacoes.ForEach(
                locacao => qtdCarro += locacao.carros.Count
            );

            return qtdCarro;
        }

        public static ClienteModels GetCliente(int idCliente)
        {
            return ClienteModels.GetCliente(idCliente);
        }

        public static List<ClienteModels> GetClientes()
        {
            return ClienteModels.GetClientes();
        }

    }
}