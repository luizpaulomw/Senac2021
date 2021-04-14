using System;
using Models;
using Controllers;
using System.Linq;
using System.Collections;

namespace View
{
    public class CarroView
    {
        public static void InserirCarro()
        {
            Console.WriteLine(" sobre o Carro: ");
            Console.WriteLine(" Marca: ");
            String Marca = Console.ReadLine();
            Console.WriteLine(" data de lançamento (dd/mm/yyyy): ");
            String dataLanc = Console.ReadLine();
            Console.WriteLine(" valor do carro: ");
            double valorLoc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" estoque: ");
            int estoque = Convert.ToInt32(Console.ReadLine());

  
        }

        public void GetCarro(CarroModels carro)
        {
            Console.Write(carro);
        }

        public static void ListarCarro()
        {
            Console.WriteLine("    carro  ");
            CarroController.GetCarro().ForEach(carro => Console.WriteLine(carro));
        }

       
        public static void ConsultarCarro()
        {
            Console.WriteLine("Digite o ID do Carro: ");
            int idCarro = Convert.ToInt32(Console.ReadLine());

            IEnumerable query =
            from carro in CarroController.GetCarro()
            where carro.CarroId == idCarro
            select carro.ToString();

            foreach (string carros  in query)
            {
                Console.WriteLine(carros.ToString());
            }
        }
    }
}