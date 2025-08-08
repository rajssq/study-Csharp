namespace teste;

public class Product
{
   // propriedades
   public string Name { get; set; }
   public int Preco { get; set; }
   
   //construtor
   public Product(string name, int preco)
      {
        this.Name = name;
        this.Preco = preco;
      }
   
   //metodo
   public void Info()
   {
       Console.WriteLine($"{this.Name} - R$ { this.Preco}");
   }
}