using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4;
class A {
    public A(decimal a, decimal b) {
        this.a = a;
        this.b = b;
    }

    protected decimal a = 56.20m;
    protected decimal b = 91.12m;

    public decimal C {
        get {
            return ++a - b;
        }
    }
}
