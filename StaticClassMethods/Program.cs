
// See https://aka.ms/new-console-template for more information

Worker worker1= new Worker("Cagan","Deniz","IT");

Console.WriteLine("Number of workers: "+ Worker.numberOfWorkers);

Worker worker2= new Worker("Ozen","Deniz","IT");

Console.WriteLine("Number of workers: "+ Worker.numberOfWorkers);


Console.WriteLine("5 + 7= "+ Equations.Add(5,7));



class Worker{
    public static int numberOfWorkers;
    private string name;
    private string lastName;

    private string deparment;

    public Worker(string name, string lastName, string deparment)
    {
        this.name = name;
        this.lastName = lastName;
        this.deparment = deparment;
        numberOfWorkers++;
    } 
}

  static class Equations{

    public static int Add (int sayi1, int sayi2){

        return sayi1+sayi2;
    }

    public static int Subtract (int sayi1, int sayi2){

        return sayi1-sayi2;
    }
}
