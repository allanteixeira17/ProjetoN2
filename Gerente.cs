using System;

class Gerente : Beneficios // Herança
{
    public double salario = 4300;
    public override void valeRefeição(double salario)
    {
        Console.WriteLine("Vale Refeição é R$" +(salario*0.9));
    }

    public override void valeAlimentação(double salario)
    {
        Console.WriteLine("Vale Alimentação é R$" +(salario*0.9));
    }

    public override void valeTransporte(double salario)
    {
        Console.WriteLine("Vale Transporte é R$" +(salario*0.9));
    }

    public override void diarias(double salario)
    {
        Console.WriteLine("Não existe diarias para essa Categoria" );
    }

}