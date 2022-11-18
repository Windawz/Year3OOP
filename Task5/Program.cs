namespace Task5;

class Program {
    static void Main() {
        var b1 = new B(12, 70);
        if (b1) {
            Console.WriteLine("b1 is true");
        } else {
            Console.WriteLine("b1 is false");
        }
        var b2 = new B(0, 44, 32);
        if (!b2) {
            Console.WriteLine("b2 is false");
        } else {
            Console.WriteLine("b2 is true");
        }
    }
}
