namespace Grunderna_i_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle1 = new Circle(5, "Circle 1");
            Circle myCircle2 = new Circle(6, "Circle 2");
            Console.WriteLine("----------");

            Console.WriteLine();
            Console.Write("Press Any Key To Exit The Program: ");
            Console.ReadKey();
        }
    }
}