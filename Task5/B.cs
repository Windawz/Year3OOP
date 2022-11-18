using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5;
class B : A {
    public B(decimal a, decimal b, decimal d) : base(a, b) {
        this.d = d;
        Array = new decimal[(int)a];
        for (int i = 0; i < Array.Length; i++) {
            Array[i] = C2 * i;
        }
    }
    public B(decimal a, decimal b) : this(a, b, 12.90m) { }

    private decimal d;

    public decimal this[int index] {
        get => Array[index];
        set => Array[index] = value;
    }
    public int this[char index] {
        get => OrdArray[index - 'a'];
    }

    public decimal[] Array { get; }
    public int[] OrdArray { get; } = new[] { 'a', 'b', 'c' }
        .Select(c => (int)c)
        .ToArray();
    public decimal C2 {
        get {
            if (a > 20m || b < 50m || d > 10m && d < 80m) {
                return a + b + d;
            }
            return a - b - d;
        }
    }

    public static bool operator true(B b) {
        Console.WriteLine("B.operator true called");
        return HasArrayElements(b);
    }
    public static bool operator false(B b) {
        Console.WriteLine("B.operator false called");
        return !HasArrayElements(b);
    }
    public static bool operator !(B b) {
        Console.WriteLine("B.operator ! called");
        return !HasArrayElements(b);
    }
    private static bool HasArrayElements(B b) {
        return b.Array.Length != 0;
    }
}
