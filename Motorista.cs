using System;

class Motorista : Beneficios 
{
    public double salario = 2100;

    public override void valeRefeição(double salario)
    {
        Console.WriteLine("Vale Refeição é de R$" +(salario*0.2) + " por mês");
    }

    public override void valeAlimentação(double salario)
    {
        Console.WriteLine("Vale Alimentação é de R$" +(salario*0.2) + " por mês");
    }

    
}