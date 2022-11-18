using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3;
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

    public decimal[] Array { get; }
    public decimal C2 {
        get {
            if (a > 20m || b < 50m || d > 10m && d < 80m) {
                return a + b + d;
            }
            return a - b - d;
        }
    }
}
