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
    
    public int Max(List<int> list) {
        if (list.Count == 0) {
            throw new ArgumentException("The list can't be empty");
        }

        int max = list[0];
        for (int i = 1; i < list.Count; i++) {
            if (list[i] > max) {
                max = list[i];
            }
        }

        return max;
    }
}