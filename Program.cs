// Your Program Code Here
using System;
using template_csharp_virtual_pet;
Console.WriteLine("Welcome to Virtual Pet!");
//Thread.Sleep(5000);
//Pet pet = new Pet();
//RoboPet roboPet = new RoboPet();
//OrganicPet organic = new OrganicPet();
Pet activePet;
Shelter shelter = new Shelter();
bool isrunning = true;
while (isrunning)
{

    Console.Clear();
    Console.WriteLine("Welcome to the game");
    Console.WriteLine("what would you like to do \n1.) Enter your own pet \n2.) Shows status all pets\n3.) Interact with Pet \n4.) Show all animals in the shelter\n5.) adopt a pet from the shelter \n6.) Quit");
    var respsone = Console.ReadLine();
    switch (respsone)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Would you like to add a RoboPet or Organic Pet?\n 1.) Robo Pet\n 2.) Organic Pet");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Console.Clear();
                activePet = new RoboPet();
                Console.WriteLine("Please enter pet Name");
                activePet.Name = Console.ReadLine();
                Console.WriteLine("Please enter Species of your pet");
                activePet.Species = Console.ReadLine();
                shelter.AddToShelter(activePet);
            }
            else
            {
                Console.Clear();
                activePet = new OrganicPet();
                Console.WriteLine("Please enter pet Name");
                activePet.Name = Console.ReadLine();
                Console.WriteLine("Please enter Species of your pet");
                activePet.Species = Console.ReadLine();
                shelter.AddToShelter(activePet);
            }
            
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("What would you like to check the status of Organic or Robot pet?\n 1.) Organic\n 2.) Robot");
            var userChoice = int.Parse(Console.ReadLine());
            if (userChoice == 1)
            {
                for (int i = 0; i < shelter.animalShelter.Count; i++)
                {
                    if (shelter.animalShelter[i].GetType() == typeof(OrganicPet))
                    {
                        Console.WriteLine(shelter.animalShelter[i].ToStringRepresention());
                    }
                    
                }
            }
            else
            {
                for (int i = 0; i < shelter.animalShelter.Count; i++)
                {
                    if (shelter.animalShelter[i].GetType() == typeof(RoboPet))
                    {
                        Console.WriteLine(shelter.animalShelter[i].ToStringRepresention());
                    }
                }
            }
            Console.WriteLine("Press enter to go back to main menu");
            Console.ReadLine();
            break;
        case "3":
            Console.Clear();
            Console.WriteLine("Would you like to interact with one pet or all pets?\n1.) one\n2.) All");
            var userResponse = int.Parse(Console.ReadLine());
            if (userResponse == 1)
            {
                Console.WriteLine("What pet would you like to interact with?");
                for (int i = 0; i < shelter.animalShelter.Count; i++)
                {
                    Console.WriteLine($"Name: {shelter.animalShelter[i].Name} #: {i}\n");
                }
                var userIndex = int.Parse(Console.ReadLine());
                Pet petToInteract = shelter.animalShelter[userIndex];


                Console.WriteLine("How would you like to interact with the pets? \n1.) Feed \n2.) Play\n3.) Take to doctor");
                var interactRespsone = Console.ReadLine();
                switch (interactRespsone)
                {
                    // add in Stat update for Doctor Choice
                    case "1":
                        petToInteract.Tick();
                        petToInteract.Feed();
                        Console.WriteLine(petToInteract.ToStringRepresention());
                        Console.WriteLine("Press enter to contiune");
                        Console.ReadKey();
                        break;
                    case "2":
                        petToInteract.Tick();
                        petToInteract.Play();
                        Console.WriteLine(petToInteract.ToStringRepresention());
                        Console.WriteLine("Press enter to contiune");
                        Console.ReadKey();
                        break;

                    case "3":
                        petToInteract.Tick();
                        petToInteract.SeeDoctor();
                        Console.WriteLine(petToInteract.ToStringRepresention());
                        Console.WriteLine("Press enter to contiune");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("How would you like to interact with your pet? \n1.) Feed \n2.) Play\n3.) Take to doctor");
                var multiPetRespsone = Console.ReadLine();
                switch (multiPetRespsone)
                {
                    // add in Stat update for Doctor Choice
                    case "1": 
                        for (int i = 0; i < shelter.animalShelter.Count; i++)
                        {
                            shelter.animalShelter[i].Tick();
                            shelter.animalShelter[i].Feed();
                            Console.WriteLine($"Name: {shelter.animalShelter[i].Name} #: {i}\n");
                            Console.WriteLine(shelter.animalShelter[i].ToStringRepresention());
                        }
                        Console.WriteLine("Press enter to contiune");
                        Console.ReadKey();
                        break;
                    case "2":
                        for (int i = 0; i < shelter.animalShelter.Count; i++)
                        {
                            shelter.animalShelter[i].Tick();
                            shelter.animalShelter[i].Play();
                            Console.WriteLine($"Name: {shelter.animalShelter[i].Name} #: {i}\n");
                            Console.WriteLine(shelter.animalShelter[i].ToStringRepresention());
                        }
                        Console.WriteLine("Press enter to contiune");
                        Console.ReadKey();
                        break;

                    case "3":
                        for (int i = 0; i < shelter.animalShelter.Count; i++)
                        {
                            shelter.animalShelter[i].Tick();
                            shelter.animalShelter[i].SeeDoctor();
                            Console.WriteLine($"Name: {shelter.animalShelter[i].Name} #: {i}\n");
                            Console.WriteLine(shelter.animalShelter[i].ToStringRepresention());
                        }
                        Console.WriteLine("Press enter to contiune");
                        Console.ReadKey();
                        break;
                }
            }
            break;
        case "4":
            for (int i = 0; i < shelter.animalShelter.Count; i++)
            {
                Console.WriteLine(shelter.animalShelter[i].Name);
            }
            Console.ReadKey();
            break;
        case "5":
            Console.WriteLine("What Pet would you like to adopt from the list");
            for (int i = 0; i < shelter.animalShelter.Count; i++)
            {
                Console.WriteLine($"Name: {shelter.animalShelter[i].Name} #: {i}\n");
            }
            var userInput1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"this {shelter.animalShelter[userInput1].Name} pet has been adopted from the shelter!");
            shelter.RemoveFromShelter(shelter.animalShelter[userInput1]);
            Console.ReadKey();
            break;
        case "6":
            isrunning = false;
            break;
    }
}

