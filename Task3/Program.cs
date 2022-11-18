namespace Task3;

class Program {
    static void Main() {
        var b = new B(12.80m, 23.00m);
        foreach (decimal value in b.Array) {
            Console.WriteLine(value);
        }
    }
}
