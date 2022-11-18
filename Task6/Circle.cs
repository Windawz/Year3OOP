using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6;
class Circle : IFigure {
    public Circle(double radius, string color) {
        Radius = radius;
        Color = color;
    }

    public double Radius { get; }
    public string Color { get; }
    public double Area => Math.PI * Math.Pow(Radius, 2.0);

    public string GetInfo() =>
        $"{{ {nameof(Radius)}: {Radius}; {nameof(Color)}: {Color}; {nameof(Area)}: {Area}; }}";
}
