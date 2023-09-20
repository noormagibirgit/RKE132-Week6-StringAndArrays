
// suvalise elemendi kättesaamine massiivist 


string[] snack = { "sushi", "pizza", "burger", "asian", "salad" };  // sushi indeks on 0, pizza indeks on 1, burgeri indeks on 2 jne. 

Random rnd = new Random();

int randomIndex = rnd.Next(0, snack.Length); // genereerib snacäkid 0 - 4 ni 

Console.WriteLine($"Tonight we are going to eat {snack[randomIndex]}");