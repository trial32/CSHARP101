// See https://aka.ms/new-console-template for more information

Student student1= new Student();
student1.Name="Özen";
student1.LastName="Deniz";
student1.Number=80;
student1.Classroom=1;

student1.DisplayStudentInformation();

Student student2 = new Student("İrem","Deniz",55,0);
student2.DisplayStudentInformation();

student1.DecreaseClass();
student1.DisplayStudentInformation();

class Student{
    private string name;
    private string lastName;
    private int number;
    private int classroom;

    public Student(string name, string lastName, int number, int classroom)
    {
        this.Name = name;
        this.LastName = lastName;
        this.Number = number;
        this.Classroom = classroom;
    }
    public Student(){}
    public string Name { 
        get {return name;} 
        set {name = value;}
    }
    public string LastName { get => lastName; set => lastName = value; }
    public int Number { 
        get => number; 
        set {
             number = value;
        } 
    
    }
    public int Classroom { 
        get => classroom; 
        set {
            if (value<1){
                Console.WriteLine("You can not set this value to classroom");
                classroom=1;
            }
            else
                classroom = value;
        }  
    }

    public void DisplayStudentInformation(){

        Console.WriteLine("************Student Information**********");
        Console.WriteLine("Student's name: " + this.Name);
        Console.WriteLine("Student's lastName: " + this.LastName);
        Console.WriteLine("Student's number: "+ this.Number);
        Console.WriteLine("Student's classRoom: " + this.Classroom);
    }
  
    public void IncreaseClass(){

        this.Classroom=this.Classroom+1;
    }
     public void DecreaseClass(){
        
        this.Classroom=this.Classroom-1;
       
    }

}
