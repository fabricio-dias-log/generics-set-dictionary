using GenericsSetDictionary.Entities;

namespace GenericsSetDictionary;

class Program
{
    static void Main(string[] args) {
        int option;

        do {
            Console.WriteLine("----------MENU----------");
            Console.WriteLine("1 - Print Service");
            Console.WriteLine("------------------------");
            Console.WriteLine("2 - Calculation Service");
            Console.WriteLine("------------------------");
            Console.WriteLine("0 - Exit");
            Console.Write("Select an option:");
            option = int.Parse(Console.ReadLine() ?? "0");
            Console.Clear();
            switch (option) {
                case 1: {
                    PrintService<int> printService = new PrintService<int>();
                    printService.Init(printService);
                    break;
                }
                case 2: {
                    CalculationService calculationService = new CalculationService();
                    calculationService.Init(calculationService);
                    break;
                }
                case 0:
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        } while (option != 0);
    }
}