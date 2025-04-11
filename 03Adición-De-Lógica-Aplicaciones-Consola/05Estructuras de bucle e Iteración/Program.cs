// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

//ODO: Convert the if-elseif -else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:



            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        case 1:


            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        case 2:


            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        case 3:


            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
        default:

            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options






do


{
    menuSelection = displayMenu();

    Console.WriteLine($"You selected menu option {menuSelection}.");

    switch (menuSelection)
    {
        case "exit":

            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();
            break;
        case "1":

            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();
            displayAnimals();
            break;
        case "2":
            addAnimal();
            break;
        case "3":
            checkIncompleteAgesAndPhysicalData();
            break;
        case "4":
            checkIncompleteNicknamesAndPersonalityData();
            break;
        case "5":
            Console.WriteLine("Please, introduce the code of the animal to change it's age:");
            editAnimalAge(Console.ReadLine());
            break;
        case "6":
            Console.WriteLine("Please, introduce the code of the animal to change it's Personality Description:");
            editAnimalPersonality(Console.ReadLine());
            break;
        case "7":
            Console.WriteLine("Please, introduce the characteristic of the cats you want to search");
            displayCatWithCharacteristic(Console.ReadLine());
            break;
        case "8":
            Console.WriteLine("Please, introduce the characteristic of the dogs you want to search");
            displayDogWithCharacteristic(Console.ReadLine());
            break;
        default:

            Console.WriteLine("Your input was incorrect, please select a valid option");
            menuSelection = displayMenu();
            break;
    }
} while (menuSelection != "exit");

// pause code execution









string displayMenu()
{
    string readResult = "";
    /*     Console.Clear(); */

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");
    readResult = Console.ReadLine();

    if (readResult != "ID #: ")
    {
        readResult = readResult.ToLower();
    }
    return readResult;
}

void displayAnimals()
{
    for (int i = 0; i < ourAnimals.GetLength(0); i++)
    {
        if (ourAnimals[i, 0] != "ID #: ")
        {
            for (int j = 0; j < ourAnimals.GetLength(1); j++)
            {
                Console.WriteLine(ourAnimals[i, j]);

            }
            Console.ReadLine();
        }

    }


}

bool checkArray()
{

    bool arrayIsFull = true;

    Console.WriteLine("You have selected to add a new animal");

    for (int i = 0; i < ourAnimals.GetLength(0); i++)
    {
        if (ourAnimals[i, 0] == "ID #: ")
        {
            arrayIsFull = false;
            return arrayIsFull;
        }

    }

    return arrayIsFull;
}

void addAnimal()
{
    bool animalAdded = false;
    if (checkArray() == false)
    {

        Console.WriteLine("Please introduce the animal data in this order: \n-ID #: \n-Species: \n-Age: \n-Nickname: \n-Physical description: \n-Personality:");
        for (int i = 0; i < ourAnimals.GetLength(0); i++)
        {
            if (ourAnimals[i, 0] == "ID #: " && animalAdded == false)
            {
                for (int j = 0; j < ourAnimals.GetLength(1); j++)
                {
                    ourAnimals[i, j] += Console.ReadLine();
                }
                animalAdded = true;
                Console.WriteLine($"Congratulations! you succesfully added {ourAnimals[i, 3]} into the fold");
            }

        }
    }
    else
    {
        Console.WriteLine("Sorry, there is no more space for new Animals on the Contoso PetFriends app, please, somehow delete one entry to log a new Animal");
        Console.ReadLine();
    }

}
void checkIncompleteAgesAndPhysicalData()
{
    bool undefinedAnimal = false;
    string animalID = "";
    foreach (string animal in ourAnimals)
    {
        if (animal.StartsWith("ID #: "))
        {
            animalID = animal;
        }
        if (animal.EndsWith("ID #: "))
        {
            undefinedAnimal = true;
        }
        if (animal.StartsWith("Age: ") && undefinedAnimal == false)
        {
            if (animal.EndsWith(" ") || animal.EndsWith("?"))
            {
                Console.WriteLine($"It seems the animal with {animalID} doesn't have a valid data for Age");
                Console.ReadLine();
            }
        }
        else if (animal.StartsWith("Physical description: ") && undefinedAnimal == false)
        {
            if (animal.EndsWith(" ") || animal.EndsWith("?"))
            {
                Console.WriteLine($"It seems the animal with {animalID} doesn't have a valid data for Physical description");
                Console.ReadLine();
                undefinedAnimal = false;

            }
        }

    }


}



void checkIncompleteNicknamesAndPersonalityData()
{
    bool undefinedAnimal = false;
    string animalID = "";
    foreach (string animal in ourAnimals)
    {
        if (animal.StartsWith("ID #: "))
        {
            animalID = animal;
        }
        if (animal.EndsWith("ID #: "))
        {
            undefinedAnimal = true;
        }
        if (animal.StartsWith("Nickname: ") && undefinedAnimal == false)
        {
            if (animal.EndsWith(" ") || animal.EndsWith("?"))
            {
                Console.WriteLine($"It seems the animal with {animalID} doesn't have a valid data for Nickname");
                Console.ReadLine();
            }
        }
        else if (animal.StartsWith("Personality: ") && undefinedAnimal == false)
        {
            if (animal.EndsWith(" ") || animal.EndsWith("?"))
            {
                Console.WriteLine($"It seems the animal with {animalID} doesn't have a valid data for Personality");
                Console.ReadLine();
                undefinedAnimal = false;

            }
        }

    }
}

void editAnimalAge(string animalID)
{
    for (int i = 0; i < ourAnimals.GetLength(0); i++)
    {
        if (ourAnimals[i, 0].EndsWith(animalID))
        {
            Console.WriteLine($"Please introduce the new age of {ourAnimals[i, 0]}");
            ourAnimals[i, 2] = "Age: " + Console.ReadLine();
            Console.WriteLine($"New data changed to {ourAnimals[i, 2]}");
            Console.ReadLine();
        }
    }
}

void editAnimalPersonality(string animalID)
{
    for (int i = 0; i < ourAnimals.GetLength(0); i++)
    {
        if (ourAnimals[i, 0].EndsWith(animalID))
        {
            Console.WriteLine($"Please introduce the new Personality Description of {ourAnimals[i, 0]}");
            ourAnimals[i, 5] = "Personality: " + Console.ReadLine();
            Console.WriteLine($"New data changed to {ourAnimals[i, 5]}");
            Console.ReadLine();
        }
    }
}

void displayCatWithCharacteristic(string characteristic)
{
    Console.WriteLine("These are the cats with matching characteristics:");

    for (int i = 0; i < ourAnimals.GetLength(0); i++){
    if (ourAnimals[i, 0].IndexOf("#: c")!= -1)
    {
        for (int j = 0; j < ourAnimals.GetLength(1); j++)
        {  

            if (ourAnimals[i,j].IndexOf(characteristic) != -1)
            {

                showAnimal(ourAnimals[i, 0]);
            }
        }
    }
}
}

void displayDogWithCharacteristic(string characteristic){
    Console.WriteLine("These are the dogs with matching characteristics:");

    for (int i = 0; i < ourAnimals.GetLength(0); i++){
    if (ourAnimals[i, 0].IndexOf("#: d")!= -1)
    {
        for (int j = 0; j < ourAnimals.GetLength(1); j++)
        {  

            if (ourAnimals[i,j].IndexOf(characteristic) != -1)
            {

                showAnimal(ourAnimals[i, 0]);
            }
        }
    }
}
}

void showAnimal(string animalID)
{
    for (int i = 0; i < ourAnimals.GetLength(0); i++)
    {
        if (ourAnimals[i, 0] == animalID)
        {
            for (int j = 0; j < ourAnimals.GetLength(1); j++)
            {
                Console.WriteLine(ourAnimals[i, j]);
            }
            Console.ReadLine();
        }
    }
}


