using System;

class Auxiliar : Beneficios 
{
    public double salario = 1200;
    
    public override void diarias(double salario)
    {
        Console.WriteLine("Não existe diaria para essa Categoria" );
    }
    
}