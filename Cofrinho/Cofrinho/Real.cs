using System;

namespace Cofrinho
{
    public class Real : Moeda

    {

        public override String info()
        {
            return "Real";
        }


        public override double converter()
        {
            return valor;
        }

    }

}