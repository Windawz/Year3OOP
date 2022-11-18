using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task6;
class SurnameComparer : IComparer<Person> {
    public int Compare(Person? x, Person? y) {
        return (x, y) switch {
            (null, null) => 0,
            (_, null) => -1,
            (null, _) => 1,
            (Person left, Person right) =>
                (left.Surname, right.Surname) switch {
                    (null, null) => 0,
                    (_, null) => -1,
                    (null, _) => 1,
                    (string leftSurname, string rightSurname) => leftSurname.CompareTo(rightSurname),
                },
            };
    }
}
