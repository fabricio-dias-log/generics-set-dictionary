using GenericsSetDictionary.Entities;

namespace GenericsSetDictionary;

class Program
{
    static void Main(string[] args)
    {
        PrintService<int> printService = new PrintService<int>();
        printService.Init(printService);
        
    }
}