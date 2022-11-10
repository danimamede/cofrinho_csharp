using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofrinho
{
    public abstract class Moeda

    {
        public double valor;

        public abstract String info();
        public abstract double converter();

    }
}