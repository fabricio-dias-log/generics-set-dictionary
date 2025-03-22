using GenericsSetDictionary.Entities;

namespace GenericsSetDictionary;

class Program
{
    static void Main(string[] args)
    {
        PrintService printService = new PrintService();
        
        Console.Write("How many values? ");
        int qty = int.Parse(Console.ReadLine());

        for (int i = 0; i < qty; i++) {
            int value = int.Parse(Console.ReadLine());
            printService.AddValue(value);
        }
        
        printService.Print();
        Console.WriteLine($"First: {printService.First()}");
    }
}