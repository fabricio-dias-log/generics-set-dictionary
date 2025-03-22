namespace GenericsSetDictionary.Entities;

public class CalculationService {

    public void Init(CalculationService calculationService) {
        List<int> list = new List<int>();
        
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        for (int i = 0; i < n; i++) {
            int x = int.Parse(Console.ReadLine() ?? "0");
            list.Add(x);
        }

        int max = calculationService.Max(list);

        Console.WriteLine($"Max: {max}");
    }
    
    // não é possivel comparar classes genericas, então necessario atribuir
    // IComparable para T para usar CompareTo()
    public T Max<T>(List<T> list) where T : IComparable { 
        if (list.Count == 0) {
            throw new ArgumentException("The list can't be empty");
        }

        T max = list[0];
        for (int i = 1; i < list.Count; i++) {
            if (list[i].CompareTo(max) > 0) {
                max = list[i];
            }
        }

        return max;
    }
}