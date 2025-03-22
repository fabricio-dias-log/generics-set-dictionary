namespace GenericsSetDictionary.Entities;

public class PrintService<T>
{
    private readonly T[] _values = new T[10];
    private int _count = 0;

    public void Init(PrintService<int> printService) {
        Console.Write("How many values? ");
        int qty = int.Parse(Console.ReadLine());

        for (int i = 0; i < qty; i++) {
            int value = int.Parse(Console.ReadLine());
            printService.AddValue(value);
        }
        
        printService.Print();
        Console.WriteLine($"First: {printService.First()}");
    }
    
    public void AddValue(T value) {
        if (_count == 10) {
            throw new InvalidOperationException("Print Service is full.");
        }
        
        _values[_count] = value;
        _count++;
    }

    public T First() {
        if (_count == 0) {
            throw new InvalidOperationException("Print Service is empty.");
        }
        return _values[0];
    }

    public void Print() {
        Console.Write("[");
        for (int i = 0; i < (_count - 1) ; i++) {
            Console.Write($"{_values[i]}, ");
        }

        if (_count > 0) {
            Console.Write(_values[_count - 1]);
        }
        
        Console.WriteLine("]");
    }
}