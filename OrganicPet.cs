using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public  class OrganicPet : Pet
    {
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        public OrganicPet()
        {
            Hunger = 60;
            Boredom = 60;
            Health = 60;
        }
        public override void Feed()
        {
            Hunger -= 10;
        }

        public override void SeeDoctor()
        {
            Health += 30;
        }

        public override void Play()
        {
            Health += 10;
            Boredom -= 20;
            Hunger += 10;
        }

        public override void Tick()
        {
            Health -= 5;
            Boredom += 5;
            Hunger += 5;
        }
        public override string ToStringRepresention()
        {
            return $"Pets Name: {Name}\nPets Hunger: {Hunger} \nPets Borodom: {Boredom}\nPets Health: {Health} \n";
        }
    }
}
