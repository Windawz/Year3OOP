using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6;
class Student : Person {
    protected const string StudentStatusString = "Student";

    public Student() : base(status: StudentStatusString) { }
    public Student(
        string? surname = null,
        DateOnly? birthDate = null,
        int? mathsRating = null,
        int? physicsRating = null,
        int? historyRating = null)
        : base(
            surname: surname,
            birthDate: birthDate,
            status: StudentStatusString) {
        MathsRating = mathsRating;
        PhysicsRating = physicsRating;
        HistoryRating = historyRating;
    }

    public int? MathsRating { get; } = null;
    public int? PhysicsRating { get; } = null;
    public int? HistoryRating { get; } = null;

    public override string GetInfo() {
        return GetMaxRating()?.ToString() ?? UnknownValueString;
    }
    protected IEnumerable<int?> EnumerateRatings() {
        yield return MathsRating;
        yield return PhysicsRating;
        yield return HistoryRating;
    }
    protected int? GetMaxRating() {
        var ratings = EnumerateRatings()
            .Where(x => x is not null)
            .Select(x => (int)x!);

        return ratings.Any() ? ratings.Max() : null;
    }
}
