using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2;
class B : A {
    public B(decimal a, decimal b, decimal d) : base(a, b) {
        this.d = d;
    }
    public B(decimal a, decimal b) : base(a, b) { }

    private decimal d = 12.90m;

    public decimal C2 {
        get {
            if (a > 20m || b < 50m || d > 10m && d < 80m) {
                return a + b + d;
            }
            return a - b - d;
        }
    }
}
