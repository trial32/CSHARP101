
// See https://aka.ms/new-console-template for more information

Worker worker1= new Worker("Cagan","Deniz","IT");

Console.WriteLine("Number of workers: "+ Worker.NumberOfWorkers);

Worker worker2= new Worker("Ozen","Deniz","IT");

Console.WriteLine("Number of workers: "+ Worker.NumberOfWorkers);


Console.WriteLine("5 + 7= "+ Equations.Add(5,7));



class Worker{
    private static int numberOfWorkers;
    private string name;
    private string lastName;

    private string deparment;

    static Worker(){
        numberOfWorkers=0;
    }

    public Worker(string name, string lastName, string deparment)
    {
        this.name = name;
        this.lastName = lastName;
        this.deparment = deparment;
        numberOfWorkers++;
    }

    public static int NumberOfWorkers { get => numberOfWorkers;} //To be able to reach it through main code
}

  static class Equations{

    public static int Add (int sayi1, int sayi2){

        return sayi1+sayi2;
    }

    public static int Subtract (int sayi1, int sayi2){

        return sayi1-sayi2;
    }
}
