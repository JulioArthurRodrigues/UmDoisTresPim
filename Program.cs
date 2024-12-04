Console.Clear();

Console.WriteLine("-------------------------------------------------");

Console.WriteLine("------------PROGRAMA DO SILVIO SANTOS------------");

Console.WriteLine("-------------------------------------------------");

Console.WriteLine("--- Vai começar o desafio UM, DOIS, TRÊS, PIM---");

Console.WriteLine("-------------------------------------------------");

for (int n = 1; n <= 40; n++)
    Console.Write(n % 4 == 0 ? "pim\n" : $"{n,8} ");
