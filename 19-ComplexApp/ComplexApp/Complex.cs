
namespace ComplexApp
{
    class Complex
    {
        double re, im;

        public Complex(double re=0, double im=0)
        {
            this.re = re;
            this.im = im;
        }

        public static Complex Polar(double abs, double phs=0)
            => new Complex(abs*Math.Cos(phs), abs*Math.Sin(phs));

        public override string ToString()
        {
            return $"{re}+{im}i";
        }

        public static Complex operator+(Complex left, Complex right)
            => left.add(right) ;

        protected Complex add(Complex z2)
        {
            return new Complex(re+z2.re, im+z2.im);
        }
    }
}
