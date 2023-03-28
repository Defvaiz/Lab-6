using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    abstract public class Integrator
    {
        abstract public double Integrate(Equation eqn, double x1, double x2, int N);
        public abstract override string ToString();
    }
}
