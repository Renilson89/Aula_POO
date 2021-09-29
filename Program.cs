using System;

//Sr. joão contratou um programador para desenvolver um programa que calcule a bonificação de seus funcionários para 
//ser incorporado ao sistema de Rh ele necessita que o programador entregue o código e o diagrama de Uml para que possa 
//conversar com o time de rh.
//Gerente Bonificação é de 500,00
//Analista Bonificação de ti é de 300,00
//Secretária Bonificação é de 100,00

namespace Aula_280921
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente Bonificação = new Gerente();
            Gerente.Gratificacao (500);
            Console.WriteLine();
            Console.WriteLine();


            Analista Bonificação = new Analista();
            Analista.Gratificacao (300);
            Console.WriteLine();
            Console.WriteLine();

            Secretaria Bonificação = new Secretaria();
            Secretaria.Gratificacao (100);
            Console.WriteLine();
            Console.WriteLine();
            
        }
    }
}
