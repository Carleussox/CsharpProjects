/* 
////////////////////////////////////////////////////////////////////PARÁMETROS DEL PROYECTO//////////////////////////////////////////////////////////
Especificación del proyecto
El proyecto de código de inicio de este módulo incluye un archivo Program.cs con las siguientes características de código:

El código declara variables usadas para recopilar y procesar datos de mascotas y selecciones de elementos de menú.

El código declara la matriz ourAnimals que incluye la siguiente información para cada animal de la matriz:

    -Identificación de mascota #
    -Especies de mascotas (gato o perro).
    -Edad de la mascota (años).
    -Descripción de la apariencia física de la mascota.
    -Descripción de personalidad de la mascota.
    -El alias de la mascota.
    -El código usa un bucle for alrededor de una construcción switch    -case para rellenar los elementos de la matriz ourAnimals.

El código incluye un bucle alrededor de un menú principal que finaliza cuando el usuario escribe "exit". El menú principal incluye:

    1 -.Enumere toda la información de mascotas de la que disponemos actualmente.
    2 -.Asigne valores a los campos de la matriz ourAnimals.
    3 -.Asegúrese de que las edades y las descripciones físicas de los animales estén completas.
    4 -.Asegúrese de que los alias y las descripciones de personalidad de los animales estén completos.
    5 -.Edite la edad de un animal.
    6 -.Edite la descripción de personalidad de un animal.
    7 -.Muestre todos los gatos con una característica especificada.
    8 -.Muestre todos los perros con una característica especificada.
    9 -.Escriba la selección de elementos de menú o escriba "Exit" para salir del programa.

El código lee la selección del elemento de menú del usuario y usa una instrucción switch para crear una rama del código de cada número de elemento de menú.

El código incluye la implementación de las opciones de menú 1 y 2.

El código muestra el mensaje "en construcción" para las opciones de menú 3-8.

El objetivo de este desafío es crear las características de la aplicación alineadas con las opciones de menú 3 y 4.

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Los animales nuevos deben agregarse a la matriz ourAnimals cuando llegan. Sin embargo, la edad de un animal y otras características físicas puede que se 
desconozcan hasta después del examen de un veterinario. Además, el alias y la personalidad de un animal puede que se desconozcan cuando una mascota llega 
por primera vez. Las nuevas características que está desarrollando se asegurarán de que exista un conjunto de datos completo para cada animal de la matriz ourAnimals.

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Para asegurarse de que las edades de los animales y las descripciones físicas estén completas, el código debe:

    -Asignar un valor numérico válido a petAge para cualquier animal al que se hayan asignado datos en la matriz ourAnimals, pero que no se le haya asignado una edad.
    -Asignar una cadena válida a petPhysicalDescription para cualquier animal al que se hayan asignado datos en la matriz ourAnimals, pero que no se le haya asignado una descripción física.
    -Compruebe que las descripciones físicas tengan un valor asignado. Los valores asignados no pueden tener cero caracteres. Cualquier requisito adicional depende del usuario.


Para asegurarse de que los alias y las descripciones de personalidad de los animales estén completos, el código debe:

    -Asignar una cadena válida a petNickname para cualquier animal al que se hayan asignado datos en la matriz ourAnimals, pero que no se le haya asignado un alias.
    -Asignar una cadena válida a petPersonalityDescription para cualquier animal al que se hayan asignado datos en la matriz ourAnimals, pero que no se le haya asignado una descripción de personalidad.
    -Compruebe que los alias y las descripciones de personalidad tienen un valor asignado. Los valores asignados no pueden tener cero caracteres. Cualquier requisito adicional depende del usuario.

 */


using System;
using System.IO;

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
int petCount = 0;
string anotherPet = "y";
bool validEntry = false;
int petAge = 0;

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

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
            animalPhysicalDescription = "large reddish  -brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean -in and give doggy hugs.";
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

// display the top  -level menu options
do
{
    Console.Clear();

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
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
        // NOTE: We could put a do statement around the menuSelection entry to ensure a valid entry, but we
        //  use a conditional statement below that only processes the valid entry values, so the do statement 
        //  is not required here. 
    }

    // use switch   -case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j].ToString());
                    }
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        case "2":
            // Add a new animal friend to the ourAnimals array
            //
            // The ourAnimals array contains
            //    1. the species (cat or dog). a required field
            //    2. the ID number  - for example C17
            //    3. the pet's age. can be blank at initial entry.
            //    4. the pet's nickname. can be blank.
            //    5. a description of the pet's physical appearance. can be blank.
            //    6. a description of the pet's personality. can be blank.

            anotherPet = "y";
            petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            }

            while (anotherPet == "y" && petCount < maxPets)
            {
                // get species (cat or dog)     - string animalSpecies is a required field 
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            //Console.WriteLine($"You entered: {animalSpecies}.");
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // build the animal the ID number   - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                // get the pet's age. can be ? at initial entry.
                do
                {
                    Console.WriteLine($"Enter the pet's age or enter ? if unknown");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);


                // get a description of the pet's physical appearance   - animalPhysicalDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (validEntry == false);


                // get a description of the pet's personality   - animalPersonalityDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (validEntry == false);


                // get the pet's nickname. animalNickname can be blank.
                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (validEntry == false);

                // store the pet information in the ourAnimals array (zero based)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                // increment petCount (the array is zero    -based, so we increment the counter after adding to the array)
                petCount = petCount + 1;

                // check maxPet limit
                if (petCount < maxPets)
                {
                    // another pet?
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "y" && anotherPet != "n");
                }
                //NOTE: The value of anotherPet (either "y" or "n") is evaluated in the while statement expression  - at the top of the while loop
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }

            break;

        case "3":
            // Ensure animal ages and physical descriptions are complete
            checkIncompleteAgesAndPhysicalData();
            Console.WriteLine("Age and physical description fields are complete for all of our friends. Press the Enter key to continue");
            Console.ReadLine();
            break;

        case "4":
            // Ensure animal nicknames and personality descriptions are complete
            checkIncompleteNicknamesAndPersonalityData();
            Console.WriteLine("Nicknames and Personality description fields are complete for all of our friends. Press the Enter key to continue");
            Console.ReadLine();
            break;

        case "5":
            // Edit an animal’s age");
            Console.WriteLine("UNDER CONSTRUCTION   - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "6":
            // Edit an animal’s personality description");
            Console.WriteLine("UNDER CONSTRUCTION   - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "7":
            // Display all cats with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION   - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "8":
            // Display all dogs with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION   - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }

} while (menuSelection != "exit");





void checkIncompleteAgesAndPhysicalData()
{
    bool validInput = false;
    string animalAge = "";
    string animalDescription = "";
    for (int i = 0; i < ourAnimals.GetLength(0); i++)
    {
        if (ourAnimals[i, 2].EndsWith("?"))
        {
            while (validInput == false)
            {
                Console.WriteLine($"Enter a valid age for {ourAnimals[i, 0]} :");
                animalAge = Console.ReadLine();
                validInput = int.TryParse(animalAge, out petAge);

            }
            ourAnimals[i, 2] = "Age: " + animalAge;
            validInput = false;

        }
        if (ourAnimals[i, 4].EndsWith(" "))
        {
            while (validInput == false)
            {
                Console.WriteLine($"Enter a valid description for {ourAnimals[i, 0]} :");
                animalDescription = Console.ReadLine();
                if (animalDescription != "")
                {
                    ourAnimals[i, 4] = "Physical description: " + animalDescription;
                    validInput = true;
                }
            }
        }
    }

}

void checkIncompleteNicknamesAndPersonalityData()
{
    bool validInput = false;
    string nickname = "";
    string animalDescription = "";
    for (int i = 0; i < ourAnimals.GetLength(0); i++)
    {
        if (!ourAnimals[i, 0].EndsWith(" "))
        {
            while (ourAnimals[i, 3].EndsWith(" "))
            {


                Console.WriteLine($"Enter a valid Nickname for {ourAnimals[i, 0]} :");
                nickname = Console.ReadLine();


                ourAnimals[i, 3] = "Nickname: " + nickname;

            }
            while (ourAnimals[i, 5].EndsWith(" "))
            {

                Console.WriteLine($"Enter a valid Personality description for {ourAnimals[i, 0]} :");
                animalDescription = Console.ReadLine();
                if (animalDescription != "")
                {
                    ourAnimals[i, 5] = "Personality: " + animalDescription;
                }

            }
        }
    }

}
/*  ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription; */