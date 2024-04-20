namespace gridview;

// Bulk simulation of database objects
public class Person {
    public int ID { get; }
    public string Name { get; }
    public string Surname { get; }

    public List<Position> Positions { get; } = new List<Position>(); 
    public Person(int id, string name, string surname) {
        ID = id;
        Name = name;
        Surname = surname;
        Positions = GetPositions();
    }
    public List<Position> GetPositions() {
        return new List<Position> {
            new Position("Programista", 5000),
            new Position("Tester", 4000),
            new Position("Analityk", 6000),
            new Position("Kierownik", 8000)
        };
    } 
}

public class Position {
    public string PositionName { get; set; }
    public double Salary { get; set; }
    public Position(string positionName, double salary) {
        PositionName = positionName;
        Salary = salary;
    }
}