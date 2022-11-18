namespace Task6;

class Program {
    static void Main() {
        Person[] people = {
            new Person("Ivanov", new(2000, 11, 14), "Businessman"),
            new Student("Sidorov", new(2003, 5, 24), 7, 5),
            new Student("Bogdanov", new(2002, 2, 14), historyRating: 10),
            new Person("Lenin", new(1870, 5, 22), "Revolutionary"),
            new Person(birthDate: new(1995, 3, 15)),
        };

        Console.WriteLine("Note: properties of further derived classes will be printed first.");
        Console.WriteLine("For example, student ratings will come before surname and birth date.");
        Console.WriteLine();

        Console.WriteLine("Default sorting (by age):");
        Array.Sort(people);
        foreach (var person in people) {
            Console.WriteLine(person);
        }
        Console.WriteLine();

        Console.WriteLine("Sorting by surname:");
        var surnameComparer = new SurnameComparer();
        Array.Sort(people, surnameComparer);
        foreach (var person in people) {
            Console.WriteLine(person);
        }
        Console.WriteLine();

        Console.WriteLine("Figures:");
        var figures = new FigureContainer(new IFigure[] {
            new Square(10),
            new Square(15),
            new Circle(12, "red"),
            new Circle(30, "blue"),
        });
        foreach (var figure in figures) {
            Console.WriteLine(figure.GetInfo());
        }
    }
}
