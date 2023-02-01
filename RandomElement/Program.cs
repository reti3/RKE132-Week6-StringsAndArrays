string[] snacks = { "sushi", "pizza", "ramen", "KFC", "poke bowl" };
Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length); //juhusliku numbri genereerimine

Console.WriteLine($"Tonight we're going to eat {snacks[randomIndex]}."); //kirjutab suvalise elemendi massiivist



