using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1;
class A {
    private decimal a = 100.58m;
    private decimal b = 230.75m;

    public decimal C {
        get {
            return ++a - b;
        }
    }
}
