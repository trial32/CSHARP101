// See https://aka.ms/new-console-template for more information


Employee employee1 = new Employee();

employee1.name="Özlem";
employee1.lastName="Yılmaz";
employee1.number=100;
employee1.department="İnsan Kaynakları";
Console.WriteLine("**************************");
employee1.DisplayEmployeeInformation();


Employee employee2 = new Employee();
employee1.name="Ahmet";
employee1.lastName="Deniz";
employee1.number=76;
employee1.department="Bilişim";

Console.WriteLine("**************************");
employee1.DisplayEmployeeInformation();  

Console.WriteLine("**************************");
Employee employee3= new Employee("Mira","Deniz",30,"Çocuk");
employee3.DisplayEmployeeInformation();

Console.WriteLine("**************************");
Employee employee4= new Employee("Özen","Deniz");
employee4.DisplayEmployeeInformation();

class Employee{

    public string name;
    public string lastName;
    public int number;
    public string department;


    public Employee(string name, string lastName, int number, string department){

        this.name=name;
        this.lastName=lastName;
        this.number=number;
        this.department=department;

    }
    public Employee(string name, string lastName){

        this.name=name;
        this.lastName=lastName;
    }
    
    public Employee(){
    }


    public void DisplayEmployeeInformation()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Last name: "+ lastName);
        Console.WriteLine("Number: "+ number);
        Console.WriteLine("Department: " + department);

    }



}
