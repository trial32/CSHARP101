

Employee employee1 = new Employee();

employee1.name="Özlem";
employee1.lastName="Yılmaz";
employee1.Number=100;
employee1.department="İnsan Kaynakları";
Console.WriteLine("**************************");
employee1.DisplayEmployeeInformation();


Employee employee2 = new Employee();
employee1.name="Ahmet";
employee1.lastName="Deniz";
employee1.Number=76;
employee1.department="Bilişim";

Console.WriteLine("**************************");
employee1.DisplayEmployeeInformation();  



class Employee{

    public string name;
    public string lastName;
    public int Number;
    public string department;

    public void DisplayEmployeeInformation()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Last name: "+ lastName);
        Console.WriteLine("Number: "+ Number);
        Console.WriteLine("Department: " + department);

    }



}
