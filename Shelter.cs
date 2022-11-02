using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Shelter 
    {
        public List<Pet> animalShelter = new List<Pet>();


        public Shelter()
        {

        }
        public  void AddToShelter(Pet name)
        {
            animalShelter.Add(name);
        }

        public void RemoveFromShelter(Pet name)
        {
            animalShelter.Remove(name);
        }


    }

    
}
