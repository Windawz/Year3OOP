using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task6;
class Person : IComparable<Person>, IComparable {
    protected const string UnknownValueString = "Unknown";

    public Person() { }
    public Person(string? surname = null, DateOnly? birthDate = null, string? status = null) : this() {
        Surname = surname;
        BirthDate = birthDate;
        Status = status;
    }

    public string? Surname { get; } = null;
    public DateOnly? BirthDate { get; } = null;
    public string? Status { get; } = null;

    public virtual string GetInfo() =>
        BirthDate?.ToString() ?? UnknownValueString;
    public override string ToString() {
        Type type = GetType();
        PropertyInfo[] properties = type.GetProperties();
        var sb = new StringBuilder("{\n");
        foreach (var property in properties) {
            sb.AppendLine($"    {property.GetValue(this) ?? UnknownValueString}; ");
        }
        sb.AppendLine($"    {nameof(GetInfo)}(): {GetInfo()}; ")
            .Append('}');
        return sb.ToString();
    }
    public int CompareTo(Person? other) {
        if (other is null) {
            return 1;
        } else if (BirthDate is null) {
            if (other.BirthDate is null) {
                return 0;
            } else {
                return -1;
            }
        } else {
            if (other.BirthDate is null) {
                return 1;
            } else {
                var left = (DateOnly)BirthDate;
                var right = (DateOnly)other.BirthDate;
                return left.CompareTo(right);
            }
        }
    }
    int IComparable.CompareTo(object? obj) =>
        CompareTo((Person?)obj);
}
