namespace ExtendedMath
{
    public class MathFunction
    {

        public static double BmiCalculator(double weight, double height)
        {
            double result = weight / (Math.Pow(height, 2));

            return result;
        }

    }
}
