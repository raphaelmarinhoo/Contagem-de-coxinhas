using System;

class Classe {
    static void Main() {
        string h, p;
        string[] line = Console.ReadLine().Split(" ");
        h = line[0];
        p = line[1];
        double media = Double.Parse(h) / Double.Parse(p);
        Console.WriteLine(string.Format("{0:0.00}", media));
    }
}



