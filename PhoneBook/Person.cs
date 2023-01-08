

public class Person{

    private string name;
    private string lastName;
    private string number;

    public Person(string name, string lastName, string number)
    {
        this.name = name;
        this.lastName = lastName;
        this.number = number;
    }

    public Person ()
    {
    }

    public string Name { get => name; set => name = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public string Number { get => number; set => number = value; }
}