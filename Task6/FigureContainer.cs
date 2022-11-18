using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6;
class FigureContainer : IEnumerable<IFigure> {
    public FigureContainer(IEnumerable<IFigure> figures) {
        _figures = figures.ToArray();
    }

    private readonly IFigure[] _figures;

    public IEnumerator<IFigure> GetEnumerator() {
        foreach (var figure in _figures) {
            yield return figure;
        }
    }
    IEnumerator IEnumerable.GetEnumerator() =>
        GetEnumerator();
}
