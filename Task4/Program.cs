namespace Task4;

class Program {
    static void Main() {
        var b = new B(12.80m, 23.00m);
        for (char c = 'a'; c < 'a' + b.OrdArray.Length; c++) {
            Console.WriteLine(b[c]);
        }
        string str1 = C<string>.Value;
        string str2 = C<int>.Value;
        Console.WriteLine($"str1: {str1}; str2: {str2}");
    }
}
