namespace Task2;
class Program {
    static void Main() {
        A a = new A(12.50m, 22.70m);
        Console.WriteLine("a.C: {0}", a.C);

        B b1 = new B(55.12m, 33.2m);
        Console.WriteLine("b1.C: {0}", b1.C);
        Console.WriteLine("b1.C2: {0}", b1.C2);

        B b2 = new B(123.77m, 75.1m, 40m);
        Console.WriteLine("b2.C: {0}", b2.C);
        Console.WriteLine("b2.C2: {0}", b2.C2);
    }
}