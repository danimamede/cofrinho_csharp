using Cofrinho;
using System;

public class Euro : Moeda

{
    // Cotação do Euro referente ao dia 11/10

    public override String info()
    {
        return "Euro";
    }


    public override double converter()
    {
        return valor * 5.28;
    }

}