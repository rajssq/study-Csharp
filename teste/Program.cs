namespace teste;

class Program
{
    static void Main(string[] args)
    {
        //study

        //basic
        string name = "Raissa";
        int idade = 20; //32 bits - exato | Usado em geral para contadores, índices, etc.
        long test = 20; //64 bits - exato | Útil quando int não é suficiente

        //fracoes
        float float1 = 10.1f; //4 bits | Pode ter imprecisão em cálculos - Cálculos científicos, gráficos 3D
        double double1 = 10.1; //8 bits | Mais preciso q float, mais usado - Cálculos matemáticos gerais
        decimal decimal1 = 10.1M; //16 bits | Alta precisão decimal, ótimo para finanças 

        //boleano
        bool bool1 = true;
        bool bool2 = false;

        //char
        char char1 = 'a';

        Console.WriteLine($"Nome: {name} | idade: {idade}"); //interpolacao
        Console.WriteLine(float1); 
        Console.WriteLine(double1);
        Console.WriteLine(bool1);
        Console.WriteLine(bool2);
        Console.WriteLine($"Letra: {char1}");
    }
}