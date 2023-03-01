namespace AreaCalculator
{

    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius), radius, "Radius is less than 0.");
            }

            Radius = radius;
        }

        public override double GetArea()
        {
            return (Math.PI * Radius * Radius);
        }
    }

    public class Triangle : Shape
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }
        public bool IsRight(int decimals = 3)
        {

            var maxSide = Math.Max(SideA, Math.Max(SideB, SideC));
            if (SideA == maxSide)
            {
                return Pythagorean(SideA, SideB, SideC, decimals);
            }
            else if (SideB == maxSide)
            {
                return Pythagorean(SideB, SideA, SideC, decimals);
            }
            else return Pythagorean(SideC, SideA, SideB, decimals);

        }

        public Triangle(double SideA, double SideB, double SideC)
        {
            if (SideA < 0 || SideB < 0 || SideC < 0)
                throw new ArgumentOutOfRangeException();

            this.SideA = SideA;
            this.SideB = SideB;
            this.SideC = SideC;   
        }

        public override double GetArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        private bool Pythagorean(double hypotenuse, double leg1, double leg2, int precisionDecimals)
        {
            return Math.Round(hypotenuse * hypotenuse, precisionDecimals) == Math.Round(leg1 * leg1 + leg2 * leg2, precisionDecimals);
        }
    }

    

}

