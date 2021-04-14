using System;
using Models;
using Controllers;
using System.Linq;
using System.Collections;

namespace View
{
    public class CaminhaoView
    {
        public static void InserirCaminhao()
        {
            Console.WriteLine(" sobre o Caminhao: ");
            Console.WriteLine(" Marca: ");
            String Marca = Console.ReadLine();
            Console.WriteLine(" data de lançamento (dd/mm/yyyy): ");
            String dataLanc = Console.ReadLine();
            Console.WriteLine(" valor do caminhao: ");
            double valorLoc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" estoque: ");
            int estoque = Convert.ToInt32(Console.ReadLine());

            CaminhaoController.addCaminhao(Marca, dataLanc, valorLoc, estoque);

  
        }

        public void GetCaminhao(CaminhaoModels caminhao)
        {
            Console.Write(caminhao);
        }

        public static void ListarCaminhao()
        {
            Console.WriteLine("    caminhao  ");
            CaminhaoController.GetCaminhao().ForEach(caminhao => Console.WriteLine(caminhao));
        }

       
        public static void ConsultarCaminhao()
        {
            Console.WriteLine("Digite o ID do Caminhao: ");
            int idCaminhao = Convert.ToInt32(Console.ReadLine());

            IEnumerable query =
            from caminhao in CaminhaoController.GetCaminhao()
            where caminhao.Id == idCaminhao
            select caminhao.ToString();

            foreach (string caminhoes  in query)
            {
                Console.WriteLine(caminhoes.ToString());
            }
        }
    }
}