

List<Person> phoneBook = new List<Person>();

Instructions instruction= new Instructions(phoneBook);

Initialize(); 
instruction.PrintPhoneBook();
bool continueMenu=true;
int maxMenu=6;

while(continueMenu){

    MainMenu();
    int selection= new Instructions(phoneBook).GetSelection(1,maxMenu);

    switch (selection){

        case 1:
            instruction.AddContact();
            instruction.PrintPhoneBook();
            break;

        case 2:
            instruction.DeleteOrModify(true);//true meand delete
            instruction.PrintPhoneBook();
            break;
        
        case 3:
            instruction.DeleteOrModify(false);//False means modify..
            instruction.PrintPhoneBook();
            break;

        case 4:
            instruction.PrintPhoneBook();
            break;
        
        case 5:
            instruction.SearchContact();
            break;
        case 6:
            continueMenu=false;
            break;
    }

}
void Initialize(){

    //First add 5 person in your phonebook

    phoneBook.Add(new Person("Ahmet","Yilmaz","05333332211"));
    phoneBook.Add(new Person("Mustafa","Sen","02125557778"));
    phoneBook.Add(new Person("Esra","Serin","02456111111"));
    phoneBook.Add(new Person("Mira","Seren","04324565656"));
    phoneBook.Add(new Person("Sinan","Olguc","08798833465"));

}


void MainMenu(){

        Console.WriteLine("Please make a selection...");
        Console.WriteLine("************************************");
        Console.WriteLine("(1) Add contact");
        Console.WriteLine("(2) Delete contact");
        Console.WriteLine("(3) Modify contact");
        Console.WriteLine("(4) Print phonebook");
        Console.WriteLine("(5) Search phonebook");
        Console.WriteLine("(6) Quit");

}

