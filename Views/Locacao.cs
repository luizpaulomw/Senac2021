using System;
using Models;
using Controllers;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace View
{
    public class LocacaoView
    {
        public static void InserirLocacao()
        {
            List<ClienteModels> clientes = ClienteController.GetClientes();
            List<CarroModels> carros = CarroController.GetCarro();


            int idCliente = 0;

            Console.WriteLine("\nDigite o ID Cliente:");
            idCliente = Convert.ToInt32(Console.ReadLine());

            if (idCliente <= 5)
            {
                ClienteModels cliente = clientes.Find(cliente => cliente.ClienteId == idCliente);

                LocacaoModels locacao = LocacaoController.addLocacao(1, cliente);

                int idCarro = 0;

                                         
                do
                {
                    Console.WriteLine("\nDigite o ID Filme: ");
                    Console.WriteLine("DIGITE ZERO (0) P/ FINALIZAR!");
                    idCarro = Convert.ToInt32(Console.ReadLine());

                    if (idCarro != 0)
                    {
                        CarroModels carro = carros.Find(carro => carro.CarroId == idCarro);

                        locacao.AdicionarCarro(carro);
                    }
                } while (idCarro != 0);
            }
        }

        public static void ConsultarLocacao()
        {
            Console.WriteLine("Digite o ID da Locação: ");
            int idLocacao = Convert.ToInt32(Console.ReadLine());

            IEnumerable query =
            from locacao in LocacaoController.GetLocacao()
            where locacao.LocacaoId == idLocacao
            select locacao.ToString();

            foreach (string locacoes in query)
            {
                Console.WriteLine(locacoes.ToString());
            }
        }
    }
}