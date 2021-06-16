using System;

class Gerente : Beneficios 
{
    public double salario = 3000;

    public override void valeRefeição(double salario)
    {
        Console.WriteLine("Vale Refeição é R$" +(salario*0.1)+ " por mês");
    }

    public override void valeAlimentação(double salario)
    {
        Console.WriteLine("Vale Alimentação é R$" +(salario*0.15)+ " por mês");
    }

    public override void valeTransporte(double salario)
    {
        Console.WriteLine("Vale Transporte é R$" +(salario*0.09)+ " por mês");
    }

    public override void diarias(double salario)
    {
        Console.WriteLine("Não existe diarias para essa Categoria" );
    }

}