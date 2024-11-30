Console.Clear();

Console.WriteLine("-------------------------------------------------");

Console.WriteLine("--- Vai começar o programa UM, DOIS, TRÊS, PIM---");

Console.WriteLine("-------------------------------------------------");

for (int n = 1; n <= 40; n++)
    Console.Write(n % 4 == 0 ? "pim\n" : $"{n,8} ");
   
