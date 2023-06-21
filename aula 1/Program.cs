namespace aula_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("entre com os dados do triangulo X:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());
            
            double xarea = x.Area();
            Console.WriteLine($"A area de x é: {xarea:F4}");

            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double yarea = y.Area();
            Console.WriteLine($"A area de y é: {yarea:F4}");

            if (xarea >= yarea) Console.WriteLine("o maior é x");
            else Console.WriteLine("o maior é Y");

        }
    }
}