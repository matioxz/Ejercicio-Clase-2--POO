using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    public class Rectangulo : FiguraGeometrica
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }

        public Rectangulo(double lado1, double lado2)
        {
            Lado1 = lado1;
            Lado2 = lado2;
        }

        public override double CalcularArea()
        {
            return Lado1 * Lado2;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Lado1 + Lado2);
        }

    }
}
