using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Task6;
class Square : IFigure {
    public Square(double side) {
        Side = side;
    }

    public double Side { get; }
    public double Perimeter => Side * 4;
    public double Area => Side * Side;

    public string GetInfo() =>
        $"{{ {nameof(Side)}: {Side}; {nameof(Perimeter)}: {Perimeter}; {nameof(Area)}: {Area}; }}";
}
