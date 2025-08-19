int counter = 10;
while (counter < 10) //verifica priemiro 
{
   Console.WriteLine($"While: {counter}");
    counter++;
}

counter = 10;
do // executa primeiro e 
{
    Console.WriteLine($"While: {counter}");
    counter++;
} while (counter < 10); // verifica depois

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"For: {i}");
}

string[] names = new string[3] { "Ana", "Bia", "Carlos" };

foreach (string name in names)
{
    Console.WriteLine($"ForEach: {name}");
}   
