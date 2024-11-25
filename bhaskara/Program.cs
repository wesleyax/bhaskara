namespace bhaskara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberA, numberB, numberC, delta;
            double x1 = 0, x2 = 0;
            Console.WriteLine("Type the value of A");
            numberA = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the value of B");
            numberB = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the value of C");
            numberC = int.Parse(Console.ReadLine());

            if (numberB != 0){ 
                delta = (numberB * numberB) - (4 * numberA * numberC);
                x1 = ((-1 * numberB) + Math.Sqrt(delta)) / (2 * numberA);
                x2 = ((-1 * numberB) - Math.Sqrt(delta)) / (2 * numberA);
            } else {
                x1 = Math.Sqrt(Math.Abs(numberC)) / numberA;
                x2 = (-1 * Math.Sqrt(Math.Abs(numberC))) / numberA;
            }

            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
            Console.ReadKey();
        }
    }
}
