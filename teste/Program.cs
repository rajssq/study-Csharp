namespace teste;

class Program
{
    static void Main(string[] args)
    {
        Product notebook = new Product("Dell Inspiron", 2500);
        notebook.Info();

        Coordenadas ponto = new Coordenadas(20, 80);
        Console.WriteLine($"Ponto: {ponto.X}, Ponto: {ponto.Y}");
    }
}