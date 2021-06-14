using System; //importar funcionalidades

//Programa para Auxiliar Setor de RH.

namespace ProgramaN2 
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Informe qual Categoria para ver os beneficios: \r\n1- Motorista\r\n2- Auxiliar\r\n3- Gerente");
            int selecao = Convert.ToInt32(Console.ReadLine());
            if(selecao == 1)
            {
            Console.WriteLine("Informe o salario de Motorista: ");
            double salarioMotorista = Convert.ToInt32(Console.ReadLine());
            //Motorista
            Beneficios objM = new Motorista();          
            Console.WriteLine("Beneficios de Motorista");
            Console.WriteLine("---------------------------\r\n");
            Console.WriteLine("Salario: " + salarioMotorista);  
            objM.valeAlimentação(salarioMotorista);
            objM.valeRefeição(salarioMotorista);
            objM.valeTransporte(salarioMotorista);
            objM.diarias(salarioMotorista);
            Console.WriteLine("---------------------------");
            }
            if(selecao == 2)
            {            
            //Auxiliar
            Console.WriteLine("Informe o salario de Auxiliar: ");
            double salarioAuxiliar = Convert.ToInt32(Console.ReadLine());
            Beneficios auxiliar = new Auxiliar();
            Console.WriteLine("Beneficios de Auxiliar");            
            Console.WriteLine("---------------------------\r\n");
            Console.WriteLine("Salario: " + salarioAuxiliar);  
            auxiliar.valeAlimentação(salarioAuxiliar);
            auxiliar.valeRefeição(salarioAuxiliar);
            auxiliar.valeTransporte(salarioAuxiliar);
            auxiliar.diarias(salarioAuxiliar);
            Console.WriteLine("---------------------------");
            }
            if(selecao == 3)
            {
            //Gerente
            Console.WriteLine("Informe o salario de Gerente: ");
            double salarioGerente = Convert.ToInt32(Console.ReadLine());

            Beneficios gerente = new Gerente();
            Console.WriteLine("Beneficios de Gerente");            
            Console.WriteLine("---------------------------\r\n");
            Console.WriteLine("Salario: " + salarioGerente);  
            gerente.valeAlimentação(salarioGerente);
            gerente.valeRefeição(salarioGerente);
            gerente.valeTransporte(salarioGerente);
            gerente.diarias(salarioGerente);
            Console.WriteLine("---------------------------");
            }

        }
    }
}
