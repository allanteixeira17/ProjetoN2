using System;

class Auxiliar : Beneficios // Herança
{
    public double salario = 1500;
    public override void diarias(double salario)
    {
        Console.WriteLine("Não existe diaria para essa Categoria" );
    }
    
}