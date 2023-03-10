namespace lab_5_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double positiveRadius = 100;
            double negativeRadius = -100;
            double zeroRadius = 0;

            try
            {
                Circle positiveCirle = new Circle(positiveRadius);
                Console.WriteLine(positiveCirle.ToString());
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Circle circle2 = new Circle(negativeRadius);
                Console.WriteLine(circle2.ToString());
            }
            catch (InvalidRadiusException ex)
            {
                
                Console.WriteLine("The radius " + ex.Radius + " is invalid");
                Console.WriteLine("Oh no Something bad happened , but we can still go on");
            }

            try
            {
                Circle circle3 = new Circle(zeroRadius);
                Console.WriteLine(circle3.ToString());
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}