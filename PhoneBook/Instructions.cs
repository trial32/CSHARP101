
public class Instructions {

List<Person> contactList = new List<Person>();

    public Instructions(List<Person> contactList)
    {
        this.contactList = contactList;
    }

    public void AddContact (){

    Console.Write("Please enter name: ");
    string name= Console.ReadLine();
    Console.Write("Please enter last name: ");
    string lastName= Console.ReadLine();
    Console.Write("Please enter phone number: ");
    string phoneNumber= Console.ReadLine();

    contactList.Add(new Person(name,lastName,phoneNumber));    
}

    public void DeleteContact(){

    Console.Write("Please enter the name or last name of your contact that you want to delete:  ");
    string input = Console.ReadLine();
    bool contactExists=false;
    int index=-1;
    Person contact;
    for (int i=0;i<contactList.Count;i++)
    {
        contact=contactList[i];
        if (contact.Name==input || contact.LastName==input ){

            contactExists=true;
            index=i;
            break;
        }
    }

    if (contactExists)
    {
        Console.Write ("{0} will be deleted from your phonebook, do you want to continue? (y/n)",input);
        while (true) {
        string selection= Console.ReadLine();
        if (selection=="y"){
            contactList.RemoveAt(index);
            Console.WriteLine(input + " is deletede from you phonebook...");
            break;
        }
            
        else if (selection == "n") {
            Console.WriteLine("Deletion is cancelled..");
            break;
        }
           
        else 
            Console.WriteLine("Please enter y or n"); 

        }        
    }
    else
     {
            Console.WriteLine("The contact could not be found in you phonebook. Pleaes make a selection: ");
            Console.WriteLine("* Quit deleting : (1) ");
            Console.WriteLine("* Try again: (2)");
            
            int newSelection=GetSelection(1,2);
            if (newSelection==2)
                DeleteContact();
    }
}

    public void DeleteOrModify (bool isDelete){
    //if isDelete=true then Delete
    //if isDelete=false then
    if (isDelete)
        Console.Write("Please enter the name or last name of your contact that you want to delete: ");
    else
        Console.Write("Please enter the name or last name of your contact that you want to modify: ");

    string input = Console.ReadLine();
    bool contactExists=false;
    int index=-1;
    Person contact;
    string newNumber="";
    for (int i=0;i<contactList.Count;i++)
    {
        contact=contactList[i];
        if (contact.Name.ToUpper()==input.ToUpper() || contact.LastName.ToUpper()==input.ToUpper() ){

            contactExists=true;
            index=i;
            break;
        }
    }

    if (contactExists)
    {
        if (isDelete)

                Console.WriteLine ("{0} will be deleted from your phonebook, do you want to continue? (y/n)",input);
        else 
            {
                Console.WriteLine("Please enter the new number: ");
                newNumber= Console.ReadLine();
                Console.Write ("{0} will be modified, do you want to continue? (y/n)",input);
            }
            

        while (true) {
        string selection= Console.ReadLine();
        if (selection=="y"){
            if (isDelete){
            contactList.RemoveAt(index);
            Console.WriteLine(input + " is deleted from you phonebook...");
            } else {             
                contactList[index].Number=newNumber;
            }
           
            break;
        }
            
        else if (selection == "n") {
            if (isDelete)
                Console.WriteLine("Deletion is cancelled..");
            else Console.WriteLine("Modification is cancelled..");
            break;
        }
           
        else 
            Console.WriteLine("Please enter y or n"); 

        }        
    }
    else
     {
            Console.WriteLine("The contact could not be found in you phonebook. Pleaes make a selection: ");
            if (isDelete)
                Console.WriteLine("* Quit deleting : (1) ");
            else 
                Console.WriteLine("* Quit deleting : (1) ");
            Console.WriteLine("* Try again: (2)");
            
            int newSelection=GetSelection(1,2);
            if (newSelection==2)
                DeleteContact();
    }


    }

    public void PrintPhoneBook(){
 
    foreach (var person in contactList)
        {
            Console.WriteLine("************************************");
            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.Number);
            Console.WriteLine("");
        }

    }

    public void SearchContact(){

        Console.WriteLine("How do you want to search?");
        Console.WriteLine("(1) By name and last name...");
        Console.WriteLine("(2) By number");

        int selection=GetSelection(1,2);

        if (selection==1)
        {
            Console.WriteLine("Please enter name or last name.");
        }else {
            Console.WriteLine("Please enter phone number");
        }
        string input=Console.ReadLine();
        Person contact;
        bool contactExists=false;
        int index=-1;
        for (int i=0;i<contactList.Count;i++)
            {
                contact=contactList[i];
                if (selection==1)
                {
                    if (contact.Name.ToUpper()==input.ToUpper() || contact.LastName.ToUpper()==input.ToUpper() ){

                    if (!contactExists) //first entrance
                    {
                        Console.WriteLine("Search results:");
                        Console.WriteLine("*************************");
                    }

                    Console.WriteLine("Name: " + contact.Name);
                    Console.WriteLine("Last Name:  "+ contact.LastName);
                    Console.WriteLine("Phone number: "+ contact.Number);
                    
                    contactExists=true;
                }
                } else if (selection==2)
                {
                if (contact.Number==input){

                    if (!contactExists) //first entrance
                    {
                        Console.WriteLine("Search results:");
                        Console.WriteLine("*************************");
                    }

                    Console.WriteLine("Name: " + contact.Name);
                    Console.WriteLine("Last Name:  "+ contact.LastName);
                    Console.WriteLine("Phone number: "+ contact.Number);
                    Console.WriteLine("*************************");
                    contactExists=true;
                    }               
                }             
            }

        if (!contactExists){
            Console.WriteLine("No data found");
            Console.WriteLine("*************************");
        } 
    }


    public int GetSelection(int min, int max){

    int result=0;

    while (true)
    {
        try
        {
            result= Convert.ToInt32(Console.ReadLine());
            if (result>=min && result<=max)
                break;
            else
                Console.WriteLine("Please enter the value between {0} and {1} ",min,max);
        }
            catch (System.Exception)
        {
            Console.WriteLine("Please enter the value between {0} and {1} ",min,max);
        }

    }
    return result;

}


}