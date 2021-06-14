using System;

class Motorista : Beneficios // Herança
{
    
    public override void valeRefeição(double salario)
    {
        Console.WriteLine("Vale Refeição é de R$" +(salario*0.2));
    }

    public override void valeAlimentação(double salario)
    {
        Console.WriteLine("Vale Alimentação é R$" +(salario*0.2));
    }

    
}