using Cofrinho;
using System;

public class Dolar : Moeda

{

    // Cotação do Dolar referente ao dia 11/10

    public override String info()
    {
        return "Dolar";
    }


    public override double converter()
    {
        return valor * 5.31;
    }

}
