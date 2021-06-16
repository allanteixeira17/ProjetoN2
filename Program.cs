using System; //importar funcionalidades

//Programa para Auxiliar Setor de RH.

namespace ProgramaN2 
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Informe qual Categoria para ver os beneficios: \r\n1- Motorista\r\n2- Auxiliar\r\n3- Gerente");
            Console.WriteLine("Categoria");
            int selecao = Convert.ToInt32(Console.ReadLine());

            if(selecao == 1)
            {            
            //Motorista
            Beneficios objM = new Motorista();
            Motorista motorista = new Motorista();
                   
            Console.WriteLine("\r\nBeneficios de Motorista");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Salario: " + motorista.salario);  
            objM.valeAlimentação(motorista.salario);
            objM.valeRefeição(motorista.salario);
            objM.valeTransporte(motorista.salario);
            objM.diarias(motorista.salario);
            Console.WriteLine("---------------------------");
            }
            if(selecao == 2)
            {            
            //Auxiliar
            Beneficios aux = new Auxiliar();
            Auxiliar auxiliar = new Auxiliar();
            
            Console.WriteLine("\r\nBeneficios de Auxiliar");            
            Console.WriteLine("---------------------------");
            Console.WriteLine("Salario: " + auxiliar.salario);  
            aux.valeAlimentação(auxiliar.salario);
            aux.valeRefeição(auxiliar.salario);
            aux.valeTransporte(auxiliar.salario);
            aux.diarias(auxiliar.salario);
            Console.WriteLine("---------------------------");
            }
            if(selecao == 3)
            {
            //Gerente
            

            Beneficios ger = new Gerente();
            Gerente gerente = new Gerente();
            Console.WriteLine("\r\nBeneficios de Gerente");            
            Console.WriteLine("---------------------------");
            Console.WriteLine("Salario: " + gerente.salario);  
            ger.valeAlimentação(gerente.salario);
            ger.valeRefeição(gerente.salario);
            ger.valeTransporte(gerente.salario);
            ger.diarias(gerente.salario);
            Console.WriteLine("---------------------------");
            }

        }
    }
}
