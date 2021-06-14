using System;

class Beneficios
{
    
       
    //Metodos
    public virtual void valeRefeição(double salario)
    {
        Console.WriteLine("Vale Refeição é de R$" +(salario*0.18));
    }
    public virtual void valeAlimentação(double salario)
    {
        Console.WriteLine("Alimentação é de R$" +(salario*0.2));
    }
    public virtual void valeTransporte(double salario)
    {
        Console.WriteLine("Vale Transporte é de R$" +(salario*0.19));
    }
    public virtual void diarias(double salario)
    {
        Console.WriteLine("Acrecimo diarias é de R$" +(salario*0.034));
    }
}
